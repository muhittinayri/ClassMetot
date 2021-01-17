using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customer_id = 1;
            customer1.customer_name = "Muhittin";
            customer1.customer_lastname = "Ayrı";
            customer1.customer_age = 23;

            Customer customer2 = new Customer();
            customer2.customer_id = 2;
            customer2.customer_name = "Ali";
            customer2.customer_lastname = "Ayrı";
            customer2.customer_age = 31;

            CustomerManager.Add(customer1);
            CustomerManager.Delete(customer1);

            Customer[] customer_list = new Customer[]
            {
                customer1,
                customer2,
            };

            CustomerManager.List(customer_list);

            Console.ReadKey();


        }
    }
}
