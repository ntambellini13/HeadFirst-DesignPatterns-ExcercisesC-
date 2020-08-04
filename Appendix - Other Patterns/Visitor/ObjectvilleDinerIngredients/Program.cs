using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectvilleDinerIngredients.Tests;

//Visitor - Represent an operation to be performed on the elements of an object structure. Visitor lets
//          you define a new operation without changing the classes of the elements on which it operates.

namespace ObjectvilleDinerIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuIngredientsTests.Run();
            Console.ReadKey();
        }
    }
}
