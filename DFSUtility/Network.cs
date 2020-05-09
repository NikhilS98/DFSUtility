using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace DFSUtility
{
    public static class Network
    {
        public static void Send(Socket server, byte[] buffer)
        {
            int bytesSent = 0, totalBytesSent = 0;
            do
            {
                bytesSent = server.Send(buffer);
                totalBytesSent += bytesSent;
            }
            while (totalBytesSent < buffer.Length);
        }

        public static byte[] Receive(Socket server)
        {
            return Receive(server, 10000);
        }

        public static byte[] Receive(Socket server, int sizeOfBuffer)
        {
            List<byte> bytesList = new List<byte>();

            byte[] buffer = new byte[sizeOfBuffer];
            int bytesTransferred = 0;
            do
            {
                bytesTransferred = server.Receive(buffer);
                for (int i = 0; i < bytesTransferred; i++)
                {
                    bytesList.Add(buffer[i]);
                }
            }
            while (bytesTransferred == sizeOfBuffer);

            return bytesList.ToArray();
        }
    }
}
