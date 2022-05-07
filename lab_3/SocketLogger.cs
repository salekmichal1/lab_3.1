using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp11
{
    class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {
            TcpClient socket = new TcpClient(host, port); // hostname="dirask.com"  and  port=80
            NetworkStream stream = socket.GetStream();

            StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
        }

        ~SocketLogger()
        {
            clientSocket.Close();
        }
        public virtual void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                using (clientSocket)
                {
                    byte[] requestBytes = Encoding.UTF8.GetBytes(message);
                    clientSocket.Send(requestBytes);
                }
            }
        }

        public void Dispose()
        {
            this.clientSocket.Close();
            GC.SuppressFinalize(this);
        }
    }

}

