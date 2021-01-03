﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 and 20");
            }

            //------------------------single line if---------------------------

            var number = 11;
            Console.WriteLine(number1 == 10 ? "Number is 10" : "Number is not 10");


            //-----------------------switch--------------------------

            var number = 30;
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                case 30:
                    Console.WriteLine("number is 30");
                    break;
                default:
                    Console.WriteLine("empty");
                    break;
            }

            //--------------------çoklu şartlar--------------------

            var number = 20;
            if (number > 0 && number <= 100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("number is between 101-200");
            }
            else if (number > 200 && number < 0)            //yada else diyebilirdik
            {
                Console.WriteLine("number is less than 0 or greater than 200");
            }

            Console.ReadLine();
        }
    }
}
