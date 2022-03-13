using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen sayıya kadar olan sayıları gösteriniz

            int z;
            Console.Write("1 sayı giriniz :");
            z = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= z; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
