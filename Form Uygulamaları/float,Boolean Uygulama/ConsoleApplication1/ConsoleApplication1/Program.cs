using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //UYGULAMA NO:6
            int x = 7;
            int y = 2;
            float fsonuc;

            // fsonuc = x + y; 9
            // fsonuc = x - y; 5
            // fsonuc = x * y; 14
            // fsonuc = x / y; 3
            // fsonuc = (float)x / y; 3,5
            // fsonuc = x / (float)y; 3,5
            // fsonuc = (float)x / (float)y; 3,5
             fsonuc = (float)(x / y);// 3
            Console.WriteLine(fsonuc);
            Console.ReadKey();
          
        }
    }
}
