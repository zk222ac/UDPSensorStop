
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDPSensorStop
{
    class Program
    {
  
        static void Main(string[] args)
        {
            int number = 0;
        
            IPAddress ip = IPAddress.Parse("127.0.0.1"); //
            UdpClient udpSender = new UdpClient("127.0.0.1", 7000);
            
            while (true)
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes("STOP.Secret");
                try
                {
                    udpSender.Send(sendBytes, sendBytes.Length);               
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                number++;
                Console.WriteLine(" " + number);
                Thread.Sleep(100);
            }

            // ReSharper disable once FunctionNeverReturns
        }

    }
}

