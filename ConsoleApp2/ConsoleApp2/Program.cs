using System;
using ConsoleApp2.Entities;


namespace ConsoleApp2
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

            User[] usersArray = new User[7];

            usersArray[0] = new User(1 , "petar", "123");
            usersArray[1] = new User(2 , "filip", "456");
            usersArray[2] = new User(3 , "igor", "789");
            usersArray[3] = new User(4 , "bojan", "555");
            usersArray[4] = new User(5, "viktor", "200");
            usersArray[5] = new User(6, "dragana", "ACC");
            usersArray[6] = new User(7, "dejan", "pass");

            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            for(int i = 0; i < usersArray.Length; i++)
            {
                if(username == usersArray[i].username)
                {
                    if(password == usersArray[i].password)
                    {
                        Console.WriteLine("You are logged in !");
                        Console.WriteLine($"Welcome {username} , here are your messages:");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
