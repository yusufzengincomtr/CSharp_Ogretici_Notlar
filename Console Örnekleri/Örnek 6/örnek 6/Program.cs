using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6. klavyeden girilen 2 sayıdan büyük ve küçük olanı 
            Büyük sayı =...
            Küçük sayı =...
            şekline gösteriniz*/
            int x, y;
            Console.Write("1.sayıyı giriniz : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz : ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x < y)
            {
                Console.Write("Büyük sayı " + y);
            }
            else if (x == y)
            {
                Console.Write("Sayılar eşittir");
            }
            else
            {
                Console.Write("Büyük Sayı " + x);
            }
            Console.ReadKey();
        }
    }
}
