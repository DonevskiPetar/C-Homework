using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise No.1
            //Console.WriteLine("Enter first number");
            //int no1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int no2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operation (+ / -)");
            //var operation = Console.ReadLine();

            //if (operation == "+")
            //{
            //    Console.WriteLine(Sum(no1, no2));
            //    Console.ReadLine();
            //}
            //else if(operation == "-")
            //{
            //    Console.WriteLine(Subtract(no1, no2));
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Enter valid input");
            //    Console.ReadLine();
            //}

            //Exercise No.2
            //Console.WriteLine("Check your c:\\ drive We will have \"fair\" elections The \\n sign means: new line");
            //Console.ReadLine();

            //Exercise No.3
            //Console.WriteLine("Enter a number to get the string length:");
            //string input = Console.ReadLine();
            //string str = "hello from sedc codecademy v7.0";
            //int num;
            //if (!int.TryParse(input, out num))
            //{
            //    Console.WriteLine("Please enter a number");
            //    Console.ReadLine();
            //}
            //else if (num < 1)
            //{
            //    Console.WriteLine("Please enter positive number");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine(str.Substring(0 , num));
            //    Console.ReadLine();
            //}


            //Exercise No.4
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today.AddDays(3));
            //Console.WriteLine(DateTime.Today.AddMonths(1));
            //Console.WriteLine(DateTime.Today.AddMonths(1).AddDays(3));
            //Console.WriteLine(DateTime.Today.AddYears(-1).AddMonths(-2));
            //Console.WriteLine(DateTime.Now.ToString("MMMM"));
            //var now = DateTime.Now;
            //int year = now.Year;
            //Console.WriteLine(year);
            //Console.ReadLine();

            //Exercise No.5
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today

            //Console.WriteLine("Enter your birthday");
            //Console.Write("Year: ");
            //int yyyy = int.Parse(Console.ReadLine());
            //Console.WriteLine("Month: ");
            //int mm = int.Parse(Console.ReadLine());
            //Console.Write("Day: ");
            //int dd = int.Parse(Console.ReadLine());

            //var birthday = new DateTime(yyyy, mm, dd);
            //var result = DateTime.Now;
            //Console.WriteLine($"You are {AgeCalculator(birthday)} years old");
            //Console.ReadLine();
        }

        //public static int AgeCalculator(DateTime param)
        //{
        //    var today = DateTime.Now;
        //    var birthday = param;
        //    if (today.Month < birthday.Month)
        //    {
        //        return today.Year - (birthday.Year + 1);
        //    }
        //    else if (today.Month == birthday.Month)
        //    {
        //        if (today.Day < birthday.Day)
        //        {
        //            return today.Year - (birthday.Year + 1);
        //        }
        //        else
        //        {
        //            return today.Year - birthday.Year;
        //        }

        //    }
        //    else
            //{
            //    return today.Year - birthday.Year;
            //}

        //}


        //Exercise No.1
        //public static int Sum(int no1 , int no2)
        //{
        //    return no1 + no2;
        //}
        //public static int Subtract(int no1 , int no2)
        //{
        //    return no1 - no2;
        //}

        //Exercise No.3
        //    public static string Substring(int n )
        //{
        //    string str = "Hello from SEDC Codecademy v7.0";
        //    return str.Substring(0 , n);
        //}

    }

}
