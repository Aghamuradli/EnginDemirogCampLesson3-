using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Babek";
            customer1.Surname = "Aghamuradli";
            customer1.Balance = 234.50;

            Customer customer2 = new Customer();
            customer2.Name = "Kenan";
            customer2.Surname = "Idayatov";
            customer2.Balance = 412.55;

            Customer[] customers = new Customer[] { customer1, customer2};

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Balance);
                Console.WriteLine("---------------");
            }


            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("---------------Add Method---------------");
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("---------------Delete Method---------------");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
        }
    }
}
