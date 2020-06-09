using Extensions;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Mentorism_V_2._0
{
    public partial class Chat : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "gyCWpgoW2nZDBDz0VmRVQJOlsZBIZdm89x96qv7h",
            BasePath = "https://mentorism-a1d5d.firebaseio.com/"
        };
        IFirebaseClient clientA;
        int surf = 0;
        int surf1 = 0;
        int portx;
        public TcpClient clientSocket;
        public NetworkStream serverStream = default(NetworkStream);
        public string readData = null;
        public Thread ctThread;
        public String name = null;
        List<string> nowChatting = new List<string>();
        List<string> chat = new List<string>();
        bool flagx = false;
        public void setName(String title)
        {
            this.Text = title;
            name = title;
        }

        [Obsolete]
        public Chat(int port, String name)
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is :" + myIP);
            Console.WriteLine(name + " " + port);
            clientSocket = new TcpClient();
            clientA = new FirebaseClient(config);
            insert(port);
            portx = port;
            try
            {
                InitializeComponent();
                clientSocket.Connect(myIP, port);
                readData = "Welcome to Mentorism V 2.0";
                msg();

                serverStream = clientSocket.GetStream();

                byte[] outStream = Encoding.ASCII.GetBytes(name + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();


                ctThread = new Thread(getMessage);
                ctThread.Start();
                this.Text = name;
                flagx = true;
            }
            catch (Exception er)
            {
                flagx = false;
                this.Controls.Remove(this.sent);
                this.Controls.Remove(this.write);
                this.Controls.Remove(this.msgs);
                this.Controls.Remove(this.avail);
                this.Controls.Remove(this.label1);
                this.Controls.Add(this.textBox1);
                this.ClientSize = new System.Drawing.Size(444, 181);
            }
        }

        private async void insert(int Port)
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }
            Console.WriteLine(macAddress);
            FirebaseResponse response1 = await clientA.GetAsync("count/" + macAddress);
            cntdata todo = response1.ResultAs<cntdata>();
            string data = null;
            if (todo != null)
            {
                data = todo.hcount;
                surf = Convert.ToInt32(data);

            }
            int newserf = surf + 1;
            SetResponse response;
            SetResponse responsew;
            response = await clientA.SetAsync("recent/" + macAddress + "/" + newserf + "/code", Port);
            responsew = await clientA.SetAsync("count/" + macAddress + "/hcount", newserf);
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            write.Init("Write Something . . .");
        }

        private void write_TextChanged(object sender, EventArgs e)
        {
            if (write.Text == "Write Something . . .")
            {
                write.Init("Write Something . . .");
            }
        }
        public void getUsers(List<string> parts)
        {
            this.Invoke((MethodInvoker)delegate
            {
                avail.Items.Clear();
                for (int i = 1; i < parts.Count; i++)
                {
                    avail.Items.Add(parts[i]);

                }
            });
        }
        private void sent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!write.Text.Equals(""))
                {
                    if (select.Items.Count == 0)
                    {
                        chat.Add("gChat");
                        chat.Add("to Everyone : " + write.Text);
                        byte[] outStream = ObjectToByteArray(chat);

                        serverStream.Write(outStream, 0, outStream.Length);
                        serverStream.Flush();
                        write.Text = "";
                        chat.Clear();
                    }
                    else
                    {
                        List<string> ids = new List<string>();
                        for (int index = 0; index < select.Items.Count; index++)
                        {
                            ids.Add(select.Items[index].ToString());
                        }
                        string result = string.Join(", ", ids);
                        Console.WriteLine(result);
                        chat.Add("gChat");
                        chat.Add("to " + result + " : " + write.Text);
                        byte[] outStream = ObjectToByteArray(chat);
                        serverStream.Write(outStream, 0, outStream.Length);
                        serverStream.Flush();
                        write.Text = "";
                        chat.Clear();
                        select.Items.Clear();
                        ids.Clear();
                    }

                }
            }
            catch (Exception er)
            {

            }
        }

        private void getMessage()
        {
            try
            {
                while (true)
                {
                    serverStream = clientSocket.GetStream();
                    byte[] inStream = new byte[10025];
                    serverStream.Read(inStream, 0, inStream.Length);
                    List<string> parts = null;

                    if (!SocketConnected(clientSocket))
                    {
                        MessageBox.Show("You've been Disconnected");
                        ctThread.Abort();
                        clientSocket.Close();
                    }

                    parts = (List<string>)ByteArrayToObject(inStream);
                    switch (parts[0])
                    {
                        case "userList":
                            getUsers(parts);
                            break;

                        case "gChat":
                            readData = "" + parts[1];
                            msg();
                            break;
                    }

                    if (readData[0].Equals('\0'))
                    {
                        readData = "Reconnect Again";
                        msg();


                        ctThread.Abort();
                        clientSocket.Close();
                        break;
                    }
                    chat.Clear();
                }
            }
            catch (Exception e)
            {
                ctThread.Abort();
                clientSocket.Close();
                Console.WriteLine(e);
            }

        }
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                msgs.Text = msgs.Text + Environment.NewLine + " " + readData;
        }
        public byte[] ObjectToByteArray(object _Object)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, _Object);
                return stream.ToArray();
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
        bool SocketConnected(TcpClient s)
        {
            bool flag = false;
            try
            {
                bool part1 = s.Client.Poll(10, SelectMode.SelectRead);
                bool part2 = (s.Available == 0);
                if (part1 && part2)
                {
                    this.Invoke((MethodInvoker)delegate // cross threads
                    {

                    });
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
            return flag;
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (flagx)
            {
                try
                {
                    chat.Add("pslvmark42");
                    byte[] outStream = ObjectToByteArray(chat);

                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();
                    chat.Clear();
                }
                catch (Exception er)
                {
                    Console.WriteLine(er);
                }
            }
        }

        private void msgs_TextChanged(object sender, EventArgs e)
        {
            msgs.SelectionStart = msgs.Text.Length;
            msgs.ScrollToCaret();
        }

        private void avail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(avail.Items[avail.SelectedIndex].ToString());
            String name = avail.Items[avail.SelectedIndex].ToString();
            if (!select.Items.Contains(name))
            {
                select.Items.Add(name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagx)
            {
                try
                {
                    chat.Add("pslvmark42");
                    byte[] outStream = ObjectToByteArray(chat);

                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();
                    chat.Clear();
                    this.Dispose();
                }
                catch (Exception er)
                {
                    Console.WriteLine(er);
                }
            }
        }

        private async void saveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }
            Console.WriteLine(macAddress);
            FirebaseResponse response1 = await clientA.GetAsync("ChatSaveCount/" + macAddress);
            cntdata todo = response1.ResultAs<cntdata>();
            string data = null;
            if (todo != null)
            {
                data = todo.hcount;
                surf1 = Convert.ToInt32(data);

            }
            int newserf = surf1 + 1;
            SetResponse response;
            SetResponse responsew;
            if (!msgs.Text.Equals(Environment.NewLine + "Welcome to Mentorism V 2.0"))
            {
                response = await clientA.SetAsync("recentSaved/" + macAddress + "/" + newserf + "/code", portx);
                response = await clientA.SetAsync("recentSaved/" + macAddress + "/" + newserf + "/msg", msgs.Text);
                responsew = await clientA.SetAsync("ChatSaveCount/" + macAddress + "/hcount", newserf);
                msgs.Text = msgs.Text + Environment.NewLine + Environment.NewLine + " [Private] Database : Message saved successfully . . . " + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Nothing to save");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!msgs.Text.Equals("Welcome to Mentorism V 2.0"))
            {
                string path = @".\SavedChats";

                try
                {
                    if (Directory.Exists(path))
                    {
                        Console.WriteLine("That path exists already.");
                        return;
                    }
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                }
                catch (Exception er)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
                finally {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(@".\SavedChats\" + portx + ".txt");
                    file.WriteLine(msgs.Text);
                    file.Close();
                    msgs.Text = msgs.Text + Environment.NewLine + Environment.NewLine + " [Private] Local Chat : Message saved successfully at /SavedChats as " + portx + ".txt" + Environment.NewLine;

                }

                
            }
            else
            {
                MessageBox.Show("Nothing to save");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
