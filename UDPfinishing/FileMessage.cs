using System;
using System.Collections.Generic;


namespace UDPfinishing
{
    class FileMessage
    {
        public byte Preamble { get; set; }
        public byte Sender { get; set; }
        public byte Reciever { get; set; }
        public byte Counter { get; set; }
        public FrameType Type { get; set; } 
        public byte[] FileChunk { get; set; }
    
  
    public FileMessage(byte receiver, byte counter, FrameType type, byte[] filechunk, byte sender)
    {
        Sender = sender;
        Reciever = receiver;
        Counter = counter;
        FileChunk = filechunk;
        Type = type;

    }
        //instead of ConcatenateToSend in chatprotocol
        public byte[] Encode()
    {
        List<byte> frame = new List<byte>();
        frame.Add(Preamble);
        frame.Add(Sender);
        frame.Add(Reciever);
        frame.Add((byte)Type);
        frame.Add(Counter);
        frame.Add((byte)FileChunk.Length);
        frame.AddRange(FileChunk);
  
        return frame.ToArray();
    }
        //instead of SplitToMessage in chatprotocol
        public void Decode(byte[] frame)
    {
        Preamble = frame[0];
        Sender = frame[1];
        Reciever = frame[2];
        Type = (FrameType)frame[3];
        Counter = frame[4];
        byte length = frame[5];
        FileChunk = new byte[length];
        for (int i = 0; i < length; i++)
        {
            FileChunk[i] = frame[6 + i];
        }
    }
}



public enum FrameType
    {
        Start = 0,
        Ack = 1,
        Data = 2,
        Stop = 3
    }
}
