using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faktöriyel hesabı  3!=1*2*3  0!=1 dir
            int s, f = 1;
            Console.WriteLine("bir sayı giriniz");
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=s; i++)
            {
                f = f * i;
            }
            Console.WriteLine("sayının faktöriyeli;  "+f);
            Console.ReadKey();
        }
    }
}
