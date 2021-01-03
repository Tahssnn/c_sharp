using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Add();                    //added!
            Add();
            Add();

            //2
            var result = Add2(50);       //80
            Console.WriteLine(result);

            //3
            int number1 = 50;
            int number2 = 100;
            var result2 = Add3(ref number1, number2); // 130
            Console.WriteLine(result2);
            Console.WriteLine(number1);   //ref olursa 30 ref olmazsa 50 olur.

            //4
            Console.WriteLine(Multiply(4, 6));   //24

            //5
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7));   //28

            Console.ReadLine();

        }
        static void Add()   //1
        {
            Console.WriteLine("added!");
        }
        static int Add2(int number1, int number2 = 30) //2
                                                       // void yerine int yazdık döndürmek istediğimiz veri tipi
        {                                              // ekstra bilgi default değeri atadık 30                   
            var result = number1 + number2;
            return result;

        }
        static int Add3(ref int number1, int number2) //3
                                                      // ref keyword ile gönderirsek number 1 hep referans değer olur.
        {                                              // ref benzeri bir de out keyword vardır!
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2) //4
        {
            return number1 * number2;
        }
        static int Add4(params int[] numbers) //5

        {

            return numbers.Sum();

        }
    }

}
