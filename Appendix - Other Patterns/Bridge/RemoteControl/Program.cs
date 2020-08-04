using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlTV.Tests;

//Bridge - Decouple an abstraction from its implementation so that the two can vary independently.

namespace RemoteControlTV
{
    public class Program
    {
        static void Main(string[] args)
        {
            RemoteControlTestDrive.Run();
            Console.ReadKey();
        }
    }
}
