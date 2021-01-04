using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {   //1
            string[] students = new string[3];  // 3 elemanlı students adında bir array tanımlıyoruz.
            students[0] = "Engin";  // students arrayınin 0. elemanı
            students[1] = "Derin";
            students[2] = "Salih";
            //2
            string[] students2 = new[] { "Engin", "Derin", "Salih" };       //aynı şey 2. tanımlama şekli daha pratik
            //3
            string[] students3 = { "Engin", "Derin", "Salih" };             //new demeden de yazabilirdik

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            //-------------------------------4-Çok boyulu dizi-------------------------------------------------

            string[,] regions = new string[4, 3]      // 4 satır 3 kolunlu
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Antalya","Adana","Mersin" },
                {"Samsun","Rize","Sinop" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
                Console.WriteLine("**********************");
            }


            Console.ReadLine();
        }
    }
}
