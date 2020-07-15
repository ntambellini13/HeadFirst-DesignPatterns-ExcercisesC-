using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeTheater.Model;
using HomeTheater.Tests;

// Facade - provides a unified interface to a set of interface in a subsytem. Facade defines
//          a higher-level interface that makes the subsystem easier to use.

namespace HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterTestDrive.Run();
            Console.ReadKey();
        }
    }
}
