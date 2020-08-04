using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MightyGumballEmail.Tests;

//Chain of Responsibility - Avoid coupling the sender of a request to its reciever by giving more than one object
//                          to handle the request. Chain the recieving objects and pass the request along the chain
//                          until an object handles it.

namespace MightyGumballEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailTests.Run();
            Console.ReadKey();
        }
    }
}
