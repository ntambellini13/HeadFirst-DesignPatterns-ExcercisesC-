using System;

using TripBuilder.Tests;

//Builder - Separate the construction of a complex object from its representation so that the same 
//          construction process can create different representations.

namespace TripBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            TripPlannerTestDrive.Run();
            Console.ReadKey();
        }
    }
}
