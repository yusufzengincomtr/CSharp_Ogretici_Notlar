using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_244
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, adet = 0, toplam = 0, ort = 0;
            Console.WriteLine("1.Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            //arada kaç adet sayı oldugunu Büyksayı-kücksayı-1 ile buluruz
            if (s1 > s2)//bs s1, ks s2 dir. örnegın s1:6 s2:3  yapması gereken (4+5)/adet
            {
                adet = s1 - s2 - 1;

                for (int i = s2 + 1; i < s1; i++)
                {
                    toplam = toplam + i;
                }

                ort = toplam / adet;
                Console.WriteLine(s1 + " ile " + s2 + " arasındaki sayıların ortalaması: " + ort);
            }
            else if (s2 > s1) //b2
            {
                adet = s2 - s1 - 1;
                for (int i = s1 + 1; i < s2; i++)
                {
                    toplam = toplam + i;
                }
                ort = toplam / adet;
                Console.WriteLine(s1 + " ile " + s2 + " arasındaki sayıların ortalaması: " + ort);
            }
            else
            {
                Console.WriteLine("DOğru sayı giriniz ");
            }
            Console.ReadKey();

        }
    }
}
