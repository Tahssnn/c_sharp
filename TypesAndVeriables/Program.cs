using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVeriables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1 = 10;  //her veri tipinin bir sınırı vardır.   32bit
            long number2 = 2147483647;   //64bit
            short number3 = -32768;  //16bit
            byte number4 = 255;    //8bit = 1bayt      0 ile 255 arası veri tutar.
            bool condition = true;  // true - false
            char character = 'A';      // (int)character dönüşümü yaparsak 64 elde ederiz.
            double number5 = 10.4;     // ondalıklı sayıları tutabiliyoruz. 64bit
            decimal number6 = 10.4m; // tamsayı olsa sadece 10 yazılır. 
       
            var number7 = 10; // number 7 yi var keyword int olarak kabul eder.

            Console.WriteLine("number1 is {0} number2 is {1} number3 is {2} number4 is {3} condition is {4} character is {5} number5 is {6} number6 is {7}",number1,number2, number3, number4, condition, character, number5, number6);

            Console.WriteLine(Days.Friday); // indexlerini örneğin monday = 10 diyerek değiştirebiliriz.

            Console.ReadLine();
        }
    }
    enum Days   // önemli
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
