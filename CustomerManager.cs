using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congratulations. Successfully added : " + customer.Name + " " + customer.Surname + " Balance : " + customer.Balance);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Congratulations. Successfully deleted : " + customer.Name + " " + customer.Surname);
        }
    }
}
