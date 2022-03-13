using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORNEK10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 1;
            Console.WriteLine("taban değerini giriniz: ");//4
            int taban= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kuvvet değeriniz: ");//2
            int kuvvet= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kuvvet; i++)
            {
                sonuc = sonuc * taban;
            }
            Console.WriteLine(sonuc);//1*4=4 4*4=16
            Console.ReadKey();
        }
    }
}
