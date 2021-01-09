using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo2();

            ////interfaces tek başına bir anlamı yoktur. new lenemezler
            //IPerson person = new Customer(); // fakat customer ve student olarak newlenebilir.

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
             };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal()); // sql e göre çalışssın
            customerManager.Add(new OracleCustomerDal()); ; // oracle göre çalışsın böylece programın bağımlılığını en aza indirmiş olduk.
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Science"
            };
            manager.Add(student);
            manager.Add(customer);
        }
    }

    //soyut nesne = interfafce
    interface IPerson       // interface büyük I harfi ile başlar
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    //somut nesne = class
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) // parametre olarak bir ekleme yapılcak bana person nesnesi ver
        {
            Console.WriteLine(person.FirstName);
        }
    }

}

