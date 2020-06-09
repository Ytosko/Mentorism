using com.sun.tools.javac.comp;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentorism_V_2._0
{
    
    public partial class dlg : Form
    {
        public String typex;
        public dlg(String type)
        {
            typex = type;
            Console.WriteLine(typex);
            InitializeComponent();
        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dlg_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void Okbtn_Click(object sender, EventArgs e)
        {

            String username = name.Text;
            int port = (int)pin.Value;
            Console.WriteLine(username + " " + port);
            if (username == "" || port < 1000)
            {
                MessageBox.Show("Name or Pin can not be empty and pin can not be smaller than 1000");
            }
            else
            {
                if (typex == "Join")
                {
                    Chat ox = new Chat(port, username);
                    ox.Show();
                    this.Dispose();
                }
                else if (typex == "Create")
                {
                    bool isAvailable = true;
                    IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                    TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

                    foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
                    {
                        if (tcpi.LocalEndPoint.Port == port)
                        {
                            isAvailable = false;
                            break;
                        }
                    }
                    if (isAvailable)
                    {

                        try
                        {
                            Thread thread = new Thread(new ThreadStart(delegate ()
                            {
                                Server t = new Server(port);
                            }));
                            thread.Start();
                            Chat ox = new Chat(port, username);
                            ox.Show();
                            this.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("The pin is currently in use! Please Choose another pin");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The pin is currently in use! Please Choose another pin");
                    }
                }
            }
        }
    }
}
