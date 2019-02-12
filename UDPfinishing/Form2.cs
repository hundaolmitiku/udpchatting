using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace UDPfinishing
{
    
    public partial class Form2 : Form
    {
   
        Socket sck;
        public string username, senderport, receiverport, userstatus;
        public string[] status = { "Available", "Unavailable", "Offline", "Busy" };
      
        public Form2()
        {

            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
            txtsenderip.Text = GetLocalIP();
            txtreciverip.Text = GetLocalIP();

            txtsenderip.Text = Properties.Settings.Default.IP_sender;
            txtreciverip.Text = Properties.Settings.Default.Ip_reciver;
            txtportreciver.Text = Properties.Settings.Default.port_reciver.ToString();
            txtsenderport.Text = Properties.Settings.Default.port_sender.ToString();
            txtboxuser.Text = Properties.Settings.Default.UserName;
            cmboxstatus.Text = Properties.Settings.Default.Status;
            cmboxstatus.Items.AddRange(status);

        }
        private String GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)//gets the list of ip addresses that are assoicated with a host
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

       
        

        private void MessageCallBack(IAsyncResult ar)
        {
            throw new NotImplementedException();
        }

        private void txtsenderport_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtportreciver_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            Properties.Settings.Default.IP_sender = txtsenderip.Text;
            Properties.Settings.Default.Ip_reciver = txtreciverip.Text;
            Properties.Settings.Default.port_sender = Int32.Parse(txtsenderport.Text.ToString());
            Properties.Settings.Default.port_reciver = Int32.Parse(txtportreciver.Text.ToString());
            Properties.Settings.Default.UserName = txtboxuser.Text;
            Properties.Settings.Default.Status = cmboxstatus.Text;

            Properties.Settings.Default.Save();
            this.Close();

        }

        private void cmboxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
