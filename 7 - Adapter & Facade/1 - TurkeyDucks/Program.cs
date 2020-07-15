using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TurkeyDucks.Model;
using TurkeyDucks.Tests;

// Adapter- Converts the interface of a class into another interface the client expects. Adapters let
//          classes work together that couldn't otherwise because of incompatible interfaces.

namespace TurkeyDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckTestDrive.Run();
            Console.ReadKey();
        }
    }
}
