using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Tests;

// Observer - Defines a one-to-many dependency between objects so that when once object changes state,
//            all of its dependents are notified and updated automatically.

namespace WeatherMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation.Run();
            Console.ReadKey();
        }
    }
}
