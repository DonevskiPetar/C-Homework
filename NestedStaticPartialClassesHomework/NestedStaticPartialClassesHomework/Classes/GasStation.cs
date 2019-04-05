using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedStaticPartialClassesHomework.Classes
{
    public static class GasStation
    {
          public static void Refill(Car car)
          {
            Random rnd = new Random();
            int fuel = rnd.Next(25);
            car.IsDriveable = true;
            Console.WriteLine($"The car {car.Brand} {car.Model} was refueled.{fuel} Liters of fuel were added.");
          }
        
        public static void PumpUpTires(Car car)
        {
            Console.WriteLine($"The {car.Brand} has pumped up the tyres.The car now is in good state");
        }
    }
}
