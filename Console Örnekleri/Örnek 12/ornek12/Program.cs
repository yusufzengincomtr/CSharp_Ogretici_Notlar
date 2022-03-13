using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ve 100 arasındaki sayılardan 5 e ve 7 ye tam bölünenleri ekranda gösteriniz.
            for (int i = 1; i <= 100; i=i+5)
            {
                Console.Write(i);                         // if (i%5==0 && i%7==0)
            }
            Console.ReadKey();
        }
    }
}
