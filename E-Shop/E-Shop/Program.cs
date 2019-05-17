using Classes.Classes;
using Classes.VendorsAndProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtensionMethods.RegisterUser();
            ExtensionMethods.UserActions();


            

            Console.ReadLine();
        }
    
    }
}
