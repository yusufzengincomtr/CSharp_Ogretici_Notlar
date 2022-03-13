using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen sayının - 0 + olma durumunu kontrol eden program 
            int x;
            Console.Write("Bir sayı giriniz = ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0)
                Console.Write("Sayı pozitiftir");
            else
                Console.Write("Sayı negatiftir");
            Console.ReadKey();
                 
        }
    }
}
