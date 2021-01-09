using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMAnager customerManager = new CustomerMAnager();  // class'ın bir referansını oluşturduk.
            customerManager.Add();
            customerManager.Update();

            ProductMAnager productManager = new ProductMAnager();  //2 class'ın bir referansını oluşturduk.
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Demiroğ"

            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

}
