using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    public class Vendor
    {
        private static int _count = 1;
        public int ID = _count++;
        public string VendorName { get; set; }

        public static List<Vendor> vendorList = new List<Vendor>();
        
        public Vendor(string vendorName)
        {
            this.VendorName = vendorName;
            vendorList.Add(this);
        }


        

    }
}
