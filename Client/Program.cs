﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Client");
            Client client = new Client("127.0.0.1", 8888);
            Parallel.Invoke(
            () =>
            {
                client.Send();
            },
            () =>
            {
                client.Recieve();
            }
            );

           // Console.ReadLine();
        }
    }
}
