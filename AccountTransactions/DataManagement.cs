using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactions
{
    internal class DataManagement
    {
        private static Customer _customer;
        private DataManagement() { } //colden instance ala bilmesinler. Default yaradilan constructoru ezirik
        public static Customer GetCustomer()
        {
            if (_customer == null)
            {
                _customer = new DataManagement().CreateCustomer();
            }
            return _customer;
        }


        private Customer CreateCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter your name : ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter your FinCode : ");
            customer.FinCode = Console.ReadLine();
            Console.WriteLine("Enter your PhoneNumber : ");
            customer.PhoneNumber = Console.ReadLine();
            return customer;
        }

    }
}
