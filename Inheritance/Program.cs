using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Engin"
                },
                new Student
                {
                     FirstName = "Derin"
                },
                new Person
                {
                     FirstName = "Salih"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
    class Person // class ların tek başına da bir anlamı vardır. Ama interface lerin yoktur.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person // customer ve student persondan gelmiştir kalıtım 1 classtan alınır sadece !
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
