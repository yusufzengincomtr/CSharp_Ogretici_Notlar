using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. klavyeden girilen sayının karesini ekranda gösteriniz.
            int x;
            Console.Write("Sayıyı giriniz = ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayının karesi = " + x * x);
            Console.ReadKey();

        
        }
    }
}
