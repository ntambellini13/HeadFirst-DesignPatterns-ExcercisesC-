using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Beverages.Model;
using Beverages.Tests;

// Template Method - Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.
//                   Template Method lets subclasses redefine certain steps of an algorithm without changing
//                   the algorithms structure.

namespace Beverages
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageTestDrive.Run();
            Console.ReadKey();
        }
    }
}
