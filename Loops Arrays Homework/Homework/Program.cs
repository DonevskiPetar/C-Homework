using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task No.1

            //Console.WriteLine("Enter one number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Task No.2
            //Console.WriteLine("Enter one more number:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //for(int i = number1; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Task No.2
            //Console.WriteLine("Enter one number:");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < number2; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //Console.WriteLine("Enter one more number:");
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < number3; i+=2)
            //{
            //    if(i % 1 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //Task No.3
            //Console.WriteLine("Enter a number:");
            //int number4 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number4; i++){
            //    if(i % 3 == 0 || i % 7 == 0)
            //    {
            //        continue;
            //    }if(i == 100)
            //    {
            //        Console.WriteLine("The limit is reached");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task No.4
            //string[] strArr = new string[5] { "one", "two", "three", "four", "five" };
            //double[] douArr = new double[5] { 1.5, 2.5, 3.5, 4.5, 5.5 };
            //char[] chaArr = new char[5] {'A','B','C','D','E' };
            //bool[] booArr = new bool[5] { true, true, false, true, true };
            //int[,] twoDimenArr = new int[2,2] { { 1, 2 }, { 1, 2 } };
            //int[,] twoDimenArr1 = new int[2, 2] { { 5, 6 }, { 7, 8 } };

            //Task No.5

            //int[] numArr = new int[5];
            //for(int i = 0; i<numArr.Length; i++)
            //{
            //    Console.WriteLine("Enter the numbers:");
            //    numArr[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //for(int i = 0; i < numArr.Length; i++)
            //{
            //   sum = sum + numArr[i];
            //}
            //Console.WriteLine("The result is:");
            //Console.WriteLine(sum);

            //Task No.6

            string[] names = new string[0];
            string answer;
            do
            {
                Console.WriteLine("enter a name:");
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = Console.ReadLine();
                Console.WriteLine("do you want to enter another name ( y / n)");
                answer = Console.ReadLine();
            }
            while (answer == "y");
            {
                Console.WriteLine("the names in the array are:");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }





            //string[] names = new string[1];
            //int index = 0;
            //int counter = 1;
            //string yesNo = "";

            //do
            //{
            //    Console.WriteLine("Enter a name");
            //    var input = Console.ReadLine();
            //    names[index] = input;
            //    Console.WriteLine("The name in the array is:");
            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);
            //    }
            //    Console.WriteLine("Do you want to enter another name? (Y / N)");
            //    yesNo = Console.ReadLine();
            //}

            //while (yesNo != "Y" && yesNo != "N");
            //{
            //    Console.WriteLine("Enter a valid input!");
            //    yesNo = Console.ReadLine();
            //}
            //if(yesNo == "Y")
            //{
            //    counter++;
            //    index++;
            //    Array.Resize(ref names, counter);
            //}
            //while (yesNo != "N") ;
            //Console.ReadLine();





            //Github Task No.2
            //int[] numbersArray = new int[20];
            //for(int i = 0; i <numbersArray.Length; i++){
            //    Console.WriteLine("Enter the number:");
            //    numbersArray[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The numbers in the array are:");
            //foreach (int num in numbersArray)
            //{
            //    Console.WriteLine(num);
            //}

            //Github Task No.3

            //int[] numbers = new int[5] { 10, 20, 0, 400, 50 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] == 0)
            //    {
            //        Console.WriteLine("Skipped");
            //    }
            //    else if(numbers[i].ToString().Length == 3)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            Console.ReadLine();
            
        }
    }
}
