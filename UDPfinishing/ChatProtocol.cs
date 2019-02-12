using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPfinishing
{
    class ChatProtocol
    {
        private string msg;

      
        public ChatProtocol()
        {
        }

        public string Username { get; set; }
        public string UserStatus { get; set; }
        public DateTime DateTime { get; set; }
        public string messagebody { get; set; }
        //constructor declaration of a class "chatprotocol"
        public ChatProtocol(string username, string userstatus, string message)
        {
            Username = username;
            UserStatus = userstatus;
            DateTime = DateTime.Now;
            messagebody = message;
        }

       public string ConcatenateToSend()
        {
           return Username + "," + UserStatus + "," + DateTime + "," + messagebody;
        }



        public void SplitToMessage(string stringMessage)
        {
            var array = stringMessage.Split(',');

            Username = array[0];
            UserStatus= array[1];
            DateTime = DateTime.Parse(array[2]);
            messagebody = array[3];
        }

        
    }
}
   