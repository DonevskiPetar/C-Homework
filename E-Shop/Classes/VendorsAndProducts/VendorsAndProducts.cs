using Classes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.VendorsAndProducts
{
    public static class VendorsAndProducts
    {
        public static Dictionary<Vendor, List<Product>> VendorsProducts = new Dictionary<Vendor, List<Product>>() //C# 6.0 feature: dictionary initializer
        {
            [new Vendor("Nike")] = new List<Product>
            {
                new Product("NIKE AIR MAX COMMAND LEATHER", 8000),
                new Product("NIKE METCON 4", 5000),
                new Product("ADIDAS SOLAR BOOST M", 6000),
                new Product("NIKE FLYKNIT MAX", 12000),
                new Product("NIKE ODYSSEY REACT 2 FLYKNIT", 9500),
                new Product("NIKE AIR MAX 2016", 8500),
                new Product("NIKE AIR ZOOM PEGASUS 35", 10500)
            },
            [new Vendor("SportVision")] = new List<Product>
            {
                new Product("ADIDAS BARRICADE 2018 CLAY" , 5000),
                new Product("UA VERGE 2.0 MID GTX" , 4500),
                new Product("UA CURRY 5" , 7000),
                new Product("UA CHARGED ULTIMATE 3.0" , 5700),
                new Product("UA NEWELL RIDGE LOW" , 10000),
                new Product("NIKE AIR MAX 2018", 8500),
                new Product("UA SPEEDFORM GEMINI 3" , 6000)
            },
            [new Vendor("BuzzShop")] = new List<Product>
            {
                new Product("ADIDAS SOLAR BOOST M" , 9500),
                new Product("ADIDAS ULTRABOOST" , 8800),
                new Product("ADIDAS SPRINGBLADE SOLYCE M" , 7000),
                new Product("ADIDAS BARRICADE 2018 CLAY" , 7700),
                new Product("ADIDAS HARDEN VOL. 2" , 10000),
                new Product("ADIDAS PUREBOOST XPOSE", 8500),
                new Product("ADIDAS CRAZY EXPLOSIVE 201" , 6000)
            }
        };

        public static void GetAllVendors()
        {
            foreach (var item in VendorsProducts)
            {
                Console.WriteLine(item.Key.ID +" "+ item.Key.VendorName);
            }
        }

        public static void GetAllProducts()
        {
            foreach (var item in VendorsProducts.Values)
            {
                foreach (var prod in item)
                {
                    Console.WriteLine(prod.ID+" "+prod.ProductName+" "+prod.ProductPrice);
                }
            }
        }

        public static void GetAllVendorsAndProducts()
        {
            foreach (var item in VendorsAndProducts.VendorsProducts)
            {
                Console.WriteLine(item.Key.ID + " " + item.Key.VendorName);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2.ID + " " + item2.ProductName + " " + item2.ProductPrice);
                }
            }
        }


    }
}
