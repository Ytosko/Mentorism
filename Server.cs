using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Mentorism_V_2._0
{
    class Server
    {

        public TcpListener listener;
        TcpClient client;
        String clNo;
        Dictionary<string, TcpClient> clientList = new Dictionary<string, TcpClient>();
        CancellationTokenSource cancellation = new CancellationTokenSource();
        List<string> chat = new List<string>();
        List<string> ulist = new List<string>();

        [Obsolete]
        public Server(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
            cancellation = new CancellationTokenSource();
            startServer();
        }

        public void updateUI(String m)
        {
               Console.WriteLine(m + Environment.NewLine);
        }

        

        public async void startServer()
        {
            listener.Start();
            Console.WriteLine("Server Started at " + listener.LocalEndpoint);
            Console.WriteLine("Waiting for Clients");
            try
            {
                int counter = 0;

                while (true)
                {
                    counter++;
                    //client = await listener.AcceptTcpClientAsync();
                    client = await Task.Run(() => listener.AcceptTcpClientAsync(), cancellation.Token);

                    byte[] name = new byte[50];
                    NetworkStream stre = client.GetStream(); //Gets The Stream of The Connection
                    stre.Read(name, 0, name.Length); //Receives Data 
                    String username = Encoding.ASCII.GetString(name); // Converts Bytes Received to String
                    username = username.Substring(0, username.IndexOf("$"));
                    ulist.Add(username);
                    /* add to dictionary, listbox and send userList  */
                    clientList.Add(username, client);
                    Console.WriteLine("Connected to user " + username + " - " + client.Client.RemoteEndPoint);
                    Console.WriteLine(username + " Joined ", username, false);

                    await Task.Delay(1000).ContinueWith(t => sendUsersList());


                    var c = new Thread(() => ServerReceive(client, username));
                    c.Start();

                }
            }
            catch (Exception)
            {
                listener.Stop();
            }

        }
        public void announce(string msg, string uName, bool flag)
        {
            try
            {
                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    Byte[] broadcastBytes = null;

                    if (flag)
                    {

                        chat.Add("gChat");
                        chat.Add(uName + " " + msg);
                        broadcastBytes = ObjectToByteArray(chat);
                    }
                    else
                    {
                        chat.Add("gChat");
                        chat.Add(msg);
                        broadcastBytes = ObjectToByteArray(chat);

                    }

                    broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                    broadcastStream.Flush();
                    chat.Clear();
                }
            }
            catch (Exception er)
            {

            }
        }
        public Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        public byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        public void ServerReceive(TcpClient clientn, String username)
        {
            byte[] data = new byte[1000];
            while (true)
            {
                try
                {
                    NetworkStream stream = clientn.GetStream();
                    stream.Read(data, 0, data.Length);
                    List<string> parts = (List<string>)ByteArrayToObject(data);

                    switch (parts[0])
                    {
                        case "gChat":
                            announce(parts[1], username, true);
                            break;

                        case "pslvmark42":
                            Console.WriteLine("got this");
                            clientList.Remove(username);
                            ulist.Remove(username);
                            sendUsersList();
                            break;

                    }

                    parts.Clear();
                }
                catch (Exception r)
                {
                    Console.WriteLine("Client Disconnected: " + username);
                    Console.WriteLine("Client Disconnected: " + username + "$", username, false);
                    clientList.Remove(username);
                    ulist.Remove(username);
                    sendUsersList();
                    break;
                }
            }
        }

        public void sendUsersList()
        {
            try
            {
                byte[] userList = new byte[1024];
                List<string> users = new List<string>();

                users.Add("userList");
                foreach (String name in ulist)
                {
                    users.Add(name);
                }
                userList = ObjectToByteArray(users);

                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    broadcastStream.Write(userList, 0, userList.Length);
                    broadcastStream.Flush();
                    users.Clear();
                }
            }
            catch (SocketException se)
            {
            }
        }
    }
}