using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonsterGeneration.Tests;

// Prototype - Specify the kinds of objects to create using a prototypical instance, and create new objects 
//             by copying this prototype.

namespace MonsterGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterGenerationTests.Run();
            Console.ReadKey();
        }
    }
}
