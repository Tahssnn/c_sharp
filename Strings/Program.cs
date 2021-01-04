using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro(); 1

            //2
            string sentence = "My name is Tahsin";
            var result1 = sentence.Length;  // kaç karakter var? 17
            var result2 = sentence.Clone(); // kopyasını oluşturur.
            var result3 = sentence.EndsWith("n");   // n ile mi bitiyor. True
            var result4 = sentence.StartsWith("M"); // M ile mi başlıyor? True
            var result5 = sentence.IndexOf("name"); // hangi indexte bulunuyor? 3 bulamazsa -1 verir.
            var result6 = sentence.LastIndexOf(" ");    // sondan başa doğru arama yapar.
            var result7 = sentence.Insert(0, "Hello "); // en başa Hello ekler. Hello My name is Tahsin
            var result8 = sentence.Substring(3, 4); // 3. indexten itibaren 4 tane al.
            var result9 = sentence.ToLower();   // küçük harfe çevir.
            var result10 = sentence.ToUpper();  // büyük harfe çevir.
            var result11 = sentence.Replace(" ", "-"); // My-name-is-Tahsin
            var result12 = sentence.Remove(2, 4);    // 2. indexten sonra 4 tane at. Mye is Tahsin

            Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Samsun";
            Console.WriteLine(city[0]);     // S yazar.

            foreach (var item in city)
            {
                Console.WriteLine(item);    // S A M S U N tek tek bu harflareri yazar
            }

            string city2 = " İstanbul";
            string result = city + city2;   // Samsun İstanbul yazar
            Console.WriteLine(result);

            Console.WriteLine(string.Format("{0} {1}", city, city2)); // Samsun İstanbul yazar
        }
    }
}
