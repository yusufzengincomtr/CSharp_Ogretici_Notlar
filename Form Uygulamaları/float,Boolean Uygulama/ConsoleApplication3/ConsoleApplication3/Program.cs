using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 5;
            b = 3;
            Boolean sonuc;
             sonuc = (a != 5) && (a < 10); //false
       //      sonuc = (a == 5) || (b > 10);
       //      sonuc = !(a <= b);
       //     sonuc = (a>10 && b ==3);
       //     sonuc = (a>10) && (b<a); false
       //     sonuc = (a > 10) && (b < 5) && (a !=b); False
       //     sonuc = (a < 10 || (b > 5) && (a == b)); True
            Console.WriteLine(sonuc);
            Console.ReadKey();

        }
    }
}
