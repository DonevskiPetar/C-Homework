using NestedStaticPartialClassesHomework.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedStaticPartialClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW","330","Black",20,true,true);
            Car car2 = new Car("VW", "MK5 GTI", "Red", 15, true, true);
            Car car3 = new Car("Mercedes", "C 320 AMG", "Blue", 18, true, true);
            Car car4 = new Car("Audi" , "A3 S-Line","Silver",16,true,true);
            Car car5 = new Car("Yugo", "Koral 55", "Yellow", 5, true, false);

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine($"The {car1.Brand} {car1.Model} has {car1.Color} color.");
            Console.WriteLine($"{car5.Brand} {car5.Model} has {car5.Fuel} liters of fuel!");
            Console.WriteLine($"The {car4.Brand} {car4.Model} needs new tyres.");
            Console.WriteLine($"{car2.Brand} {car2.Model} has 200 hp");
            Console.WriteLine($"The {car3.Brand} {car3.Model}needs oil change.");

            Console.WriteLine("----------------------------------------------------------------------");

            car1.StartCar();
            car1.StartLights();
            car2.StartCar();
            car2.StartLights();

            Console.WriteLine("----------------------------------------------------------------------");

            GasStation.Refill(car2);
            GasStation.Refill(car5);
            GasStation.Refill(car3);

            Console.WriteLine("----------------------------------------------------------------------");

            GasStation.PumpUpTires(car1);
            GasStation.PumpUpTires(car4);

            Console.WriteLine("----------------------------------------------------------------------");

            car2.Drive("Seavus");
            car3.Drive("Bitola");
            car5.Drive("Ohrid");

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine(Car.GetCarStats(car2));
            Console.WriteLine(Car.GetCarStats(car5));
            Console.WriteLine(Car.GetCarStats(car3));

            Console.WriteLine("----------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
