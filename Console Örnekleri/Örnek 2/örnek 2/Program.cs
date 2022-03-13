using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_2
{
    class Program
    {
        static void Main(string[] args)
        {//KULLANICIDAN ALINAN 2 SAYININ TOPLAMINI BULAN PROGRAM
            int s1, s2,toplam;
           
            Console.Write("1.sayıyı giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            toplam = s1 + s2;

            Console.WriteLine("Sonuç = " + toplam);
            Console.ReadKey();
        }
    }
    }

