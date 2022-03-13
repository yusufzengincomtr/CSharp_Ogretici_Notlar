using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek23
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen 2 sayı arasındaki sayıların ortalamasını bulan program.
            int s1, s2, ort;
            Console.WriteLine("1.Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            ort = s1 + s2 / 2;
            Console.WriteLine("Sayıların Ort: "+ort);
            Console.ReadKey();

        }
    }
}
