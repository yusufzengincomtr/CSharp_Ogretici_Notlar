using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek18
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYIYA KADAR OLAN TEK VE 3 ÜN KATI SAYILARIN TOPLAMINI GÖSTER(+OLMA ŞART)
            int sayi,toplam = 0;
            Console.WriteLine("sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>0)
            {
                    for (int i = 0; i < sayi; i++)
                    if (sayi % 2 == 1 && i % 3 == 0)
                    {
                        toplam = toplam + i;
                    }
                Console.WriteLine("toplam:  " + toplam);
                Console.ReadLine();
            }
        }
    }
}
