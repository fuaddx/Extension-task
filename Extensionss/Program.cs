using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionss
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            bool isPrime = number.Isprime();
            bool powoftwo = number.IsPowOfTwo();

            if (!isPrime)
            {
                Console.WriteLine($"{number} is prime.");
            }
            else
            {
                Console.WriteLine($"{number} is not prime.");
            }
            //pow of 2
            if (powoftwo)
            {
                Console.WriteLine($"{number} is Pow Of 2.");
            }
            else
            {
                Console.WriteLine($"{number} is not Pow Of Two.");
            }

        }
    }
}