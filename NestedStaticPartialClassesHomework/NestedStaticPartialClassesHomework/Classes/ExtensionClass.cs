using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedStaticPartialClassesHomework.Classes
{
    public static class ExtensionClass
    {
        public static void Drive(this Car car , string place)
        {
            Console.WriteLine($"Driving my {car.Brand} {car.Model} to {place}.");
            car.Fuel--;
        }
    }
}
