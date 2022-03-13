using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.klavyeden girilen sayının küpünü alan program
            int x;
            Console.Write("Sayıyı giriniz = ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayının karesi = " + x * x * x);
            Console.ReadKey();
        }
    }
}
