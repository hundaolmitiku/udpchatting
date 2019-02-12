using System;

namespace UDPfinishing
{
    internal class MessageEvent : EventArgs
    {
        public ChatProtocol Message { get; set; }
    }
}