using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop(); 1
            //WhileLoop(); 2
            //DoWhileLoop(); 3
            //ForEachLoop(); 4

            if (IsPrimeNumber(7)) //asal sayı 5
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number) //asal sayı
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;

        }

        private static void ForEachLoop()   //dizi temelli
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(students);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;   // 1er azalt.
            }
        }

        private static void ForLoop()
        {
            for (int i = 10; i <= 100; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
