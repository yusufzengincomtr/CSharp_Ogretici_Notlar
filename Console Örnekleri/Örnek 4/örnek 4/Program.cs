using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Alt alta sıralanmasını istediğiniz sayıyı giriniz:  ");
            x = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
