using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model;
using PizzaFanchise.Tests;

//Abstract Factory - Provides an interface for creating families of related or dependent objects,
//                   without specifying their concrete classes.

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
