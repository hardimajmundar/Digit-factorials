using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application8
{
    class Program
    {
        private static readonly long max = (int)Factorial(9) * 7;
        static void Main(string[] args)
        {            
            long sum = 0;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            for (int i = 3; i <= max; i++)
            {
                if (IsCuriousNumber(i))
                {
                    sum += i;
                }
            }
            //sw.Stop();
            Console.WriteLine(sum);
            //Console.WriteLine("Time to calculate in milliseconds : {0}", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
        private static long Factorial(int input)
        {
            int sum = 1;
            for (int i = 1; i <= input; i++)
            {
                sum *= i;
            }
            return sum;
        }

        private static bool IsCuriousNumber(long input)
        {
            char[] digits = input.ToString().ToCharArray();
            long sum = digits.Sum(t => Factorial((int)char.GetNumericValue(t)));
            return sum == input;
        }
    }
}