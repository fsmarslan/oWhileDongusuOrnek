using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oWhileDongusuOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen faktoriyeli hesaplanacak sayıyı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;

            while (sayi>1)
            {
                faktoriyel *= sayi;
                sayi--;
            }
            Console.WriteLine("foktoriyel: {0}",faktoriyel);
            Console.ReadKey();
        }
    }
}
