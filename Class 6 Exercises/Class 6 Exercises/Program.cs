using Class_6_Exercises.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise No.1
            //string user = "y";
            //do
            //{
            //    Console.WriteLine("Enter number to get stats");
            //    string input = Console.ReadLine();
            //    int number;

            //    if (int.TryParse(input, out number))
            //    {
            //        Console.WriteLine(NumberStatsPos(number));
            //        Console.WriteLine(NumberStatsOdd(number));
            //    }

            //    else
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //    Console.WriteLine("Do you want to enter another input? y / n");
            //    user = Console.ReadLine();
            //}

            //while (user == "y");
            //Console.ReadLine();
            #endregion Exercise No.1

            #region Exercise No.2
            //Declare Array with users
            //User[] usersArray = new User[7];
            //usersArray[0] = new User(1, "petar", "123");
            //usersArray[1] = new User(2, "filip", "456");
            //usersArray[2] = new User(3, "igor", "789");
            //usersArray[3] = new User(4, "bojan", "555");
            //usersArray[4] = new User(5, "viktor", "200");
            //usersArray[5] = new User(6, "dragana", "ACC");
            //usersArray[6] = new User(7, "dejan", "pass");

            //Console.WriteLine("Choose to: Login or Register");
            //string loginOrRegister = Console.ReadLine();

            //Login
            //if (loginOrRegister.ToLower() == "login")
            //{
            //    Console.WriteLine("Enter Username");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Enter Password");
            //    string password = Console.ReadLine();
            //    loginUser(username, password, usersArray);
            //}
            ////Register
            //else if (loginOrRegister == "register")
            //{
            //    Console.WriteLine("Enter user Id");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Username");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Enter password");
            //    string password = Console.ReadLine();
            //    registerUser(id, username, password, usersArray);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input!");
            //    Console.WriteLine("Please use login or register");
            //    Console.ReadLine();
            //}
            #endregion Exercise No.2
        }
        #region Exercise No.1
        //public static string NumberStatsPos(int number)
        //{
        //    if(number > 0)
        //    {
        //        return $"The number {number} is positive";
        //    }
        //    return $"The number {number} is negative";
        //}
        //public static string NumberStatsOdd(int number)
        //{
        //    if(number % 2 == 0)
        //    {
        //        return $"The number {number} is even";
        //    }
        //    return $"The number {number} is odd";
        //}
        #endregion Exercise No.1

        #region Exercise No.2 functions
        //Login user function
        //public static void loginUser(string username, string password, User[] usersArray)
        //{
        //    bool flag = true;
        //    for (int i = 0; i < usersArray.Length; i++)
        //    {
        //        if (username == usersArray[i].Username)
        //        {
        //            if (password == usersArray[i].Password)
        //            {
        //                flag = false;
        //                Console.WriteLine("You are logged in !");
        //                Console.WriteLine($"Welcome {username} , here are your messages:");
        //                Console.ReadLine();
        //                break;
        //            }
        //        }

        //    }
        //    if (flag)
        //    {
        //        Console.WriteLine("Wrong username or password , please try again");
        //        Console.ReadLine();
        //    }
        //}
        ////Register user function
        //public static void registerUser(int id, string username, string password, User[] usersArray)
        //{
        //    bool flag = true;
        //    for (int i = 0; i < usersArray.Length; i++)
        //    {
        //        if (id == usersArray[i].Id)
        //        {
        //            if (username == usersArray[i].Username)
        //            {
        //                flag = false;
        //                Console.WriteLine("Id or username already exist");
        //                Console.ReadLine();
        //            }
        //        }
            //}
            //if (flag)
            //{
            //    Array.Resize(ref usersArray, usersArray.Length + 1);
            //    usersArray[usersArray.Length - 1] = new User(id, username, password);
            //    Console.WriteLine("You are registered");
            //    Console.ReadLine();
            //}
        //}
        #endregion Exercise No.2 functions
    }
}

