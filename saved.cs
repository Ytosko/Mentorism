using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentorism_V_2._0
{
    public partial class saved : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "gyCWpgoW2nZDBDz0VmRVQJOlsZBIZdm89x96qv7h",
            BasePath = "https://mentorism-a1d5d.firebaseio.com/"
        };
        IFirebaseClient clientA;
        string macAddress = string.Empty;
        public saved()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
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

        private void saved_Load(object sender, EventArgs e)
        {
            Loaddata();
            LoadLoc();
        }

        private void LoadLoc()
        {
            DirectoryInfo dir = new DirectoryInfo(@".\SavedChats");
            FileInfo[] files = dir.GetFiles("*.txt");
            local.Items.Clear();
            foreach (FileInfo file in files)
            {
                local.Items.Add(file);
            }
        }

        private async void Loaddata()
        {
            FirebaseResponse response = await clientA.GetAsync("ChatSaveCount/" + macAddress);
            cntdata todo = response.ResultAs<cntdata>();
            string data = null;
            int getc = 0;
            if (todo != null)
            {
                data = todo.hcount;

                Console.WriteLine(data);
                getc = Convert.ToInt32(data);
            }
            if (getc != 0)
            {
                online.Items.Clear();
                for (int i = 1; i <= getc; i++)
                {
                    FirebaseResponse responsey = await clientA.GetAsync("recentSaved/" + macAddress + "/" + i);
                    chze todox = responsey.ResultAs<chze>();
                    if (todox != null)
                    {
                        string datar = todox.code;
                        online.Items.Add(datar);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private async void online_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(online.SelectedIndex);
            int ind = online.SelectedIndex + 1;
            Console.WriteLine(ind);
            FirebaseResponse responsey = await clientA.GetAsync("recentSaved/" + macAddress + "/" + ind);
            chze todox = responsey.ResultAs<chze>();
            if (todox != null)
            {
                string datar = todox.msg;
                msgs.Text = datar;
            }
        }

        private void local_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(local.Items[local.SelectedIndex].ToString());
            string filename = local.Items[local.SelectedIndex].ToString();
            string path = @".\SavedChats\" + filename;
            Console.WriteLine(path);
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path)) {
                    string s;
                    msgs.Text = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        msgs.Text = msgs.Text + Environment.NewLine + s;
                    }
                }
            }
            else
            {
                fnotf ox = new fnotf();
                ox.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadLoc();
        }

        private void msgs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
