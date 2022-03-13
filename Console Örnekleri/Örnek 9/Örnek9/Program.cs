using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, secim, sonuç;
            Console.WriteLine("bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayının karesi icin 2 küpü icin 3ü tuşlayın. ");
            secim = Convert.ToInt32(Console.ReadLine());

            if (secim==2)
            {
                sonuç = sayi * sayi;
                Console.WriteLine("Sayının karesini giriniz: ");
            }
            else if (secim==3)
            {
                sonuç = sayi * sayi * sayi;
                Console.WriteLine("sayının küpünü giriniz: ");
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız.");
            }
            Console.ReadKey();
        }
    }
}
