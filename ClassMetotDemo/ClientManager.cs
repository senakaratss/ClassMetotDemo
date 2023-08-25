using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+ customer.Surname+"("+ customer.Id+")" +"has been added.");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + "(" + customer.Id + ")" + "has been deleted.");
        }

    }
}
