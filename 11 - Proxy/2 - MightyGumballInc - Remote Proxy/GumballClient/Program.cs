using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GumballClient.Model;
using GumballClient.Tests;

//Proxy - Provides a surrogate or placeholder for another object to control access to it.

namespace GumballClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMonitorTestDrive.Run(args);
            Console.ReadKey();
        }
    }
}
