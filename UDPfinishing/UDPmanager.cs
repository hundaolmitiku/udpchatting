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
    class UDPmanager
    {
        Socket sck;
        EndPoint eplocal, epremote;
        private byte[] buffer;
        private TextBox listMesssage;
        private TextBox textMessage;
        public event EventHandler MessageEventHandler;
        string receivedMessage;
        delegate void SetTextCallback(string text);
        //private delegate void updateMessageListMessage(ChatProtocol message);

        public UDPmanager()
        {

        }
        public TextBox ListMesssage
        {
            get
            {
                return listMesssage;
            }

            set
            {
                listMesssage = value;
            }
        }

        public TextBox TextMessage
        {
            get
            {
                return textMessage;
            }

            set
            {
                textMessage = value;
            }
        }

        public void Getconnection()
{
    sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
    sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

           
        }
private String GetLocalIP()
{
    IPHostEntry host;
    host = Dns.GetHostEntry(Dns.GetHostName());
    foreach (IPAddress ip in host.AddressList)
    {
        if (ip.AddressFamily == AddressFamily.InterNetwork)
        {
            return ip.ToString();
        }
    }
    return "127.0.0.1";
}
        public void Start(string senderport,string reciverport)
        {
            try

            { // binding socket
                string ip = GetLocalIP();
                Getconnection();
                //int reciverport = Properties.Settings.Default.port_reciver;
                //int senderport = Properties.Settings.Default.port_sender;
                string username = Properties.Settings.Default.UserName;
                string status = Properties.Settings.Default.Status;

                eplocal = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(senderport));
                sck.Bind(eplocal);

                epremote = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(reciverport));
                sck.Connect(epremote);
               


                // starts to listen to an specific port

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new

                AsyncCallback(Messagecallback), buffer);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());

            }

        }

        

        private void Messagecallback(IAsyncResult aResult)
        {
            try
            {
                byte[] recievedData = new byte[1464];
                recievedData = (byte[])aResult.AsyncState;
                ASCIIEncoding eEncoding = new ASCIIEncoding();
                receivedMessage = eEncoding.GetString(recievedData);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote,
                                      new AsyncCallback(Messagecallback), buffer);
                ChatProtocol ClassMessage = new ChatProtocol();
                ClassMessage.SplitToMessage(receivedMessage);
                MessageEventHandler(this, new MessageEvent() { Message = ClassMessage });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
        private void SetText(string text)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listMesssage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listMesssage.AppendText(text);
                this.listMesssage.AppendText("\n");
            }
        }

        private void Invoke(SetTextCallback d, object[] v)
        {
            throw new NotImplementedException();
        }

        public void send(ChatProtocol messages)
        {
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] msg = new byte[1500];

            msg = enc.GetBytes(messages.ConcatenateToSend());
            sck.Send(msg);
        }

    }
}

