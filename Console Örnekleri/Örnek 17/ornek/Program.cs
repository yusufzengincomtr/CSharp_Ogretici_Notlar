using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayıya kadar olan sayıların çarpımını ekranda gösteriz.
            int s1, toplam = 1;
            Console.WriteLine("sayı giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            if (s1>0)
            {
                for (int i = 1; i < s1; i++)
                {
                    toplam = toplam * i;
                    
                }
                Console.WriteLine("sayıların toplamı" + toplam + "dır");
            }
            else
            {
                Console.WriteLine("pozitif sayı giriniz. programdan çıkıyorsunuz.");

            }
            Console.WriteLine("çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
