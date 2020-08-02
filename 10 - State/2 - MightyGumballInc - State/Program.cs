using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MightyGumballInc.Tests;

// State - Allows and object to alter its behaviour when its internal state changes.
//         The object will apear to change its class.

namespace MightyGumballInc
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachineTestDrive.Run();
            Console.ReadKey();
        }
    }
}
