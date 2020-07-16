using System;
using System.Net.Sockets;
using System.Text;

namespace WebApplication2.CommunicationProtocols
{
    public class ByteMessageSender
    {
        public ByteMessageSender(string hexStringCommand, string hostname = "192.168.0.155", int port = 20060)
        {
            Result = SendByteMessage(hexStringCommand, hostname, port);
        }

        private string SendByteMessage(string hexStringCommand, string hostname, int port)
        {
            string result;
            try
            {
                var client = new TcpClient(hostname, port);
                NetworkStream ns = client.GetStream();
                ns.Write(Encoding.ASCII.GetBytes(hexStringCommand));
                byte[] bytes = new byte[1024];
                result = Encoding.ASCII.GetString(bytes, 0, ns.Read(bytes, 0, bytes.Length));
                client.Close();
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }
        public string Result { get; private set; }
    }
}
