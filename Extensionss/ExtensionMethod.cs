using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionss
{
        public static class ExtensionMethod
        {
            public static bool Isprime(this int number)
            {
                bool isPrime = true;

                for (int i = 0; i <= number; i++)
                {
                    for (int j = 2; j <= number; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    isPrime = true;
                }
                return isPrime;

            }

            public static bool IsPowOfTwo(this int number)
            {
                if (number <= 0)
                    return false;

                while (number > 1)
                {
                    if (number % 2 != 0) return false;

                    number /= 2;
                }

                return true;
            }
        }
    
}
