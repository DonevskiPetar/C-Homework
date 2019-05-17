using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    public class Order
    {
        private static int _count = 1;
        public int ID { get; private set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }

        public static List<Order> orders = new List<Order>();

        public Order(int productID , string productName, int productQuantity , int productPrice)
        {
            this.ID = _count++;
            this.ProductName = productName;
            this.ProductQuantity = productQuantity;
            this.ProductPrice = productPrice;

            
        }


        public int CalculateOrderPrice()
        {
            return ProductQuantity * ProductPrice;
        }

    }
}
