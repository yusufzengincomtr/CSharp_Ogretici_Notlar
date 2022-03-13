using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Öğrencinin 2 yazılı 2 performans notunun ortalamasını bul
            int s1, s2, p1, p2,ort;
            Console.WriteLine("1.Yazılıyı giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Yazılıyı giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Performansı giriniz: ");
            p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Performansı giriniz: ");
            p2 = Convert.ToInt32(Console.ReadLine());
            ort = s1 + s2 + p1 + p2 /4;
            ort = ort / 4;
            Console.WriteLine("yazılı ve performans ort: " + ort);
            Console.ReadKey();
        }
    }
}
