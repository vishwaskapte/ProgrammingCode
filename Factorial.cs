using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCode
{
    public class Factorial
    {
        int count = 0;
        public void CountFactor(int N)
        {
            Console.WriteLine($"Current N Value is {N}");

            for(int i= 1; i*i <= N; i++)
            {
                Console.WriteLine($"Current i Value is {i} & i*i <= N Value is {i*i<=N}");
                if(N % i == 0)
                {
                    Console.WriteLine($"if N%i==0 => {N%i==0}");
                    if(i == N/i)
                    {
                        Console.WriteLine($"if i==N/i => {i == N/i}");
                        count++;
                        Console.WriteLine($"Count Value is => {count}");
                    }else
                    {
                        count = count + 2;
                        Console.WriteLine($"Count Value is => {count}");
                    }
                    Console.WriteLine($" ");
                }
                Console.WriteLine($" ");
            }
        }
    }
}
