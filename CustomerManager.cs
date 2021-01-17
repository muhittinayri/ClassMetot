using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("Yeni Müşteri Eklendi : " + customer.customer_name);
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine(customer.customer_id + " İd'li " + customer.customer_name + " İsimli Müşteri Silindi ");
        }

        public static void List(Customer[] customer)
        {
            Console.WriteLine("Tüm Müşteriler");
            foreach (var cstmr in customer)
            {
                Console.WriteLine("Müşteri: " + cstmr.customer_name + " " + cstmr.customer_lastname);
            }


        }
    }
}
