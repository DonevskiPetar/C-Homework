using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedStaticPartialClassesHomework.Classes
{
    public partial class Car
    {
        public void StartCar()
        {
            Console.WriteLine($"The car {this.Brand} {this.Model} is now running.");
        }
        public void StartLights()
        {
            Console.WriteLine($"The {this.Brand} lights are now on.");
        }
        public static string GetCarStats(Car car)
        {
            return $"The car {car.Brand} {car.Model} has {car.Fuel} liters of fuel left ," +
                $" and drivable condition is {car.IsDriveable}";
        }
    }
}
