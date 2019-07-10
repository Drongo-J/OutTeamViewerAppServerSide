using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TcpServerToClientSendSS.AddditionalClasses
{
   public class Network
    {
        

        public void StartTcpServer()
        {
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse(NetworkProtocol.IPAddress);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, NetworkProtocol.TcpPort);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                byte[] bytes = new byte[11000000];
                string data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    MessageBox.Show("Connected");
                    data = null;

                    while (true)
                    {
                        // Get a stream object for reading and writing
                        NetworkStream stream = client.GetStream();

                        int i;

                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            //data = Encoding.ASCII.GetString(bytes, 0, i);
                            //Console.WriteLine("Received: {0}", data);
                            ImageHelper imageHelper = new ImageHelper();
                            var path=imageHelper.GetImagePath(bytes, 1);
                            App.MainViewModel.Source = path;
                            // Process the data sent by the client.
                            //data = data.ToUpper();

                            //byte[] msg = Encoding.ASCII.GetBytes(data);

                            // Send back a response.
                            //stream.Write(msg, 0, msg.Length);
                            //Console.WriteLine("Sent: {0}", data);
                            break;
                        }

                    }
                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }
        }

    }
}
