using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UDPfinishing
    {
        public class FileManager
    {
        public string Filename { get; private set;}
        FileStream stream;
        public FileStream Stream
        {
            get
            {
                return stream;
            }

            set
            {
                stream = value;
            }
        }
        public FileManager(string filename)
        {
            Filename = filename;
        }
        public void PrepareFile()
        {
           
        }
        public void AppendData(int counter, byte[] chunkData)
        {
          
        }

        public byte[] ReadChunk(int counter, int totalBytes)
        {
            return new byte[totalBytes];
        }

        public void SaveAndClose()
        {
          
            Stream.Close();
        }

    }




}
