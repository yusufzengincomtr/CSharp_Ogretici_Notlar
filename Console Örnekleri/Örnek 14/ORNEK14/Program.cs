using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORNEK14
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYIYA "5 diyelim"(SAYI POZİTİF OLMAK ŞARTIYLA) KADAR OLAN SAYILARIN TOPLAMINI EKRANDA GÖSTERİNİZ.
            int sayi, toplam = 0;
            Console.WriteLine("sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                for (int i = 1; i <= sayi; i++)// İ:0 1 2 3 4 OLUNCA ÇIKTI
                {
                    toplam = toplam + i;//toplam=0+1=1  toplam=1+2=3 toplam=3+3=6 şeklinde
                }
            }
            else
            {
                Console.WriteLine("Pozitif sayı giriniz. Programdan çıkıyorsunuz");
            }
            Console.WriteLine("sayıların toplamı:" + toplam + " dır");
            Console.WriteLine("Çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
