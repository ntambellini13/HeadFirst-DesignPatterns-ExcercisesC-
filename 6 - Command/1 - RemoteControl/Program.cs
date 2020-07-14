using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControl.Model;
using RemoteControl.Tests;

// Command - Encapsulates a request as an object, thereby letting you parameterize clients with different
//           requests, queue or log requests and support undo operations.

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlTest.Run();
            Console.ReadKey();
        }
    }
}
