using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornk11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ve 100 arasındaki sayılardan 5 e tam bölünenleri ekranda gösteriniz.
            for (int i = 5; i <= 100; i+=5)//< yanına eşittir '=' koyarsan o sayıyıda yazar
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            
        }
    }
}
