using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName , string lastName , double salary , double successSaleRevenue) :base(firstName,lastName,salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            SuccessSaleRevenue = successSaleRevenue;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 800;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 2000;
            }
            else
            {
                return Salary;
            }
        }

    }
}
