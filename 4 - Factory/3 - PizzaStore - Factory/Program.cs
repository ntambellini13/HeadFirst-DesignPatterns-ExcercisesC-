using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model;
using PizzaFanchise.Tests;

//Factory Method - Defines and interface for creating an object, but let subclasses decide which class to instantiate.
//                 Factory Method lets a class defer instantiation to the subclasses.

namespace PizzaFanchise
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTestDrive.Run();

            Console.ReadKey();
        }
    }
}
