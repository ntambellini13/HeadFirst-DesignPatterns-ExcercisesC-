using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameSaver.Tests;

//Memento - Without violating encapsulation, capture and externalize an object’s internal state so 
//          that the object can be restored to this state later.

namespace GameSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Run();
            Console.ReadKey();
        }
    }
}
