using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.sun.tools.javac.comp;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace Mentorism_V_2._0
{
   
    public partial class Main : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "gyCWpgoW2nZDBDz0VmRVQJOlsZBIZdm89x96qv7h",
            BasePath = "https://mentorism-a1d5d.firebaseio.com/"
        };
        IFirebaseClient clientA;
        public Main()
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

            clientA = new FirebaseClient(config);
            InitializeComponent();

        }
 

        private void button4_Click(object sender, EventArgs e)
        {
            saved ox = new saved();
            ox.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

        private void join_Click(object sender, EventArgs e)
        {
            dlg ok = new dlg("Join");
            ok.StartPosition = FormStartPosition.CenterParent;
            ok.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            dlg ok = new dlg("Create");
            ok.StartPosition = FormStartPosition.CenterParent;
            ok.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

        private void Main_Load(object sender, EventArgs e)
        {
                loaddata();
        }

        public async void loaddata()
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
            FirebaseResponse response = await clientA.GetAsync("count/" + macAddress);
            cntdata todo = response.ResultAs<cntdata>();
            string data = null;
            int getc = 0;
            if (todo != null)
            {
                data = todo.hcount;

                Console.WriteLine(data);
                getc = Convert.ToInt32(data);
            }
            if(getc != 0)
            {
                for(int i = 1; i <= getc; i++)
                {
                    FirebaseResponse responsey = await clientA.GetAsync("recent/" + macAddress + "/" + i);
                    codecs todox = responsey.ResultAs<codecs>();
                    if (todox != null)
                    {
                        string datar = todox.code;
                        if (!recent.Items.Contains(datar))
                        {
                            recent.Items.Add(datar);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
