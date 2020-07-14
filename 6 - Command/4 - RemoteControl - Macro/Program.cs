using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlAPI.Model;
using RemoteControlAPI.Tests;

// Command - Encapsulates a request as an object, thereby letting you parameterize clients with different
//           requests, queue or log requests and support undo operations.

namespace RemoteControlAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteLoader.Run();
            Console.WriteLine();
            RemoteWithMacro.Run();
            Console.ReadKey();
        }
    }
}
