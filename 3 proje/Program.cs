using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlıcağın değer gir");
            int değer1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finish değer gir");
            int değer2 = Convert.ToInt32(Console.ReadLine());

            int[] değerler = Değerüret(değer1, değer2);
        }
        public static int[] Değerüret(int değer1 , int değer2)
        {
            Random yuhlar = new Random();
            int[] sayılsal = new int[10];
            for (int i = 0; i < sayılsal.Length; i++)
            {
                sayılsal[i] = yuhlar.Next(değer1, değer2 + 1);
            }

            return sayılsal;
        }
        public static void bilinmiyor(int[] bilinmiyom)
        {
            foreach(int kişibaşı in bilinmiyom)
            {
                Console.WriteLine(kişibaşı+ " ");
            }

        }
     
        }
    }
}
