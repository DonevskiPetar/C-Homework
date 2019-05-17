using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    public class Product
    {
        private static int _count = 1;
        public int ID = _count++;

        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public static List<Product> allPproductList = new List<Product>();

        public Product(string productName , int productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            allPproductList.Add(this);
        }

    }
}
