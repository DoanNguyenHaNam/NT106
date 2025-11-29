using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using System.Threading;

namespace Ex3
{
    internal class Socket
    {
        const string HOST = "127.0.0.1";
        const int PORT = 11000;
        const string DELIM = "<EOF>";

        public static string Send(string message)
        {
            try
            {
                TcpClient client = new TcpClient(HOST, PORT);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(message + DELIM);
                stream.Write(data, 0, data.Length);

                byte[] buffer = new byte[4096];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytes);

                stream.Close();
                client.Close();

                int cut = response.IndexOf(DELIM);
                if (cut >= 0) response = response.Substring(0, cut);

                return response;
            }
            catch (Exception ex)
            {
                return "Lỗi socket: " + ex.Message;
            }
        }
    }
}
