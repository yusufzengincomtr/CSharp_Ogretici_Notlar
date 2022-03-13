using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen 5 sayı arasından pozitif ve çift olanların toplamını bulup sonucu ekrana gösteriniz.
            int sayi, toplam=0;
            for (int i = 0; i < 5; i++)// 7 9 15 4 8
            {
                Console.WriteLine("Sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0 && sayi % 2 == 0)
                {
                    toplam = toplam + sayi; // şart sağlanırsa ..
                } // şart sağlanmazsa burdan devam eder
            }
            Console.WriteLine("toplam:" + toplam);
            Console.ReadKey(); // ....
            
        }
    }
}
