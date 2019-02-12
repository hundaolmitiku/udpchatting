using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;
     

namespace UDPfinishing
{
    public partial class Form1 : Form
    {
        UDPmanager udm = new UDPmanager();
        delegate void SetTextCallback(ChatProtocol text);



        public Form1()
        {
            InitializeComponent();
            
        }
     
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
       
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
          
            OpenFileDialog ofd = new OpenFileDialog();
           
 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                //FileManager = new FileManager(filename);
            }
        }
       

     
       
      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

       
        }

        private void buttonSend_Click(object Sender, EventArgs e)
        {
            
            string username = Properties.Settings.Default.UserName;
            string userstatus = Properties.Settings.Default.Status;

             
            ChatProtocol message = new ChatProtocol(username, userstatus, textMessage.Text);
            udm.send(message);

         
            ListMessage.AppendText("Me: " + textMessage.Text + "\n");
            //textMessage.Text = "";

        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateListMessage(ChatProtocol message)
        {
            ListMessage.AppendText(  message.Username + " "+message.UserStatus + " " + message.DateTime+Environment.NewLine+ message.messagebody +  "\n");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string Myprt = Properties.Settings.Default.port_sender.ToString();
            string Fport = Properties.Settings.Default.port_reciver.ToString();
            udm.Start(Myprt, Fport);
            udm.MessageEventHandler += Udm_MessageEventHandler;//subscribe
        }

        private void Udm_MessageEventHandler(object sender, EventArgs e)

        {
           MessageEvent ms = e as MessageEvent;
            this.Invoke(new SetTextCallback(UpdateListMessage), ms.Message);
        }
    }
    }

    


