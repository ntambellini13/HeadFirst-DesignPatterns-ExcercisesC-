using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Landscaponator.Tests;

//Flyweight - Use sharing to support large numbers of fine-grained objects efficiently. A flyweight is a shared object
//            that can be used in multiple contexts simultaneously. The flyweight acts as an independent objectin in
//            each context; it’s indistinguishable from an instance of the object that’s not shared.

namespace Landscaponator
{
    class Program
    {
        static void Main(string[] args)
        {
            LandscaponatorTests.Run();
            Console.ReadKey();
        }
    }
}
