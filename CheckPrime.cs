using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCode
{
    public class CheckPrime
    {
        public void CheckNumberPrimeIsPrimeOrNot(int number)
        {
            // You can change the value of n to test different numbers

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        public bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false; // 1 is not a prime number
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false; // If num is divisible by i, it's not a prime number
                }
            }

            return true; // If no divisors found, it's a prime number
        }
    }

}
