using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoHouse.Tests;

//Mediator - Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by
//           keeping objects from referring to each other explicitly, and lets you vary their interaction independently.

namespace AutoHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoHouseTests.Run();
            Console.ReadKey();
        }
    }
}
