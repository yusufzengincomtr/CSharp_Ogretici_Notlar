using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYIYA KADAR OLAN TEK SAYILARIN TOPLAMINI GÖSTEREN PROGRAM.(POZİTİF OLMAK ŞARTIYLA).
            int sayi, toplam = 0;
            Console.WriteLine("sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());//ÖRNEGİN KULLANICI 8 GİRMİŞ OLSUN SONUC  1+3+5+7=16 OLMALI SONUC
            if (sayi>0)
            {
                for (int i = 1; i <=sayi ; i++) //İ 
                {
                    if (i%2==1)
                    {
                        toplam = toplam + i;
                    }
                }
                Console.WriteLine("sayıların toplamı:" + toplam + "dır");
            }
            else
            {
                Console.WriteLine("Pozitif sayı giriniz.Programdan çıkıyorsunuz.");
            }
            Console.WriteLine("Çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }
        }
    }

