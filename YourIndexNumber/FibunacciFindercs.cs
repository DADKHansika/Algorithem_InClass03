using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourIndexNumber
{
    public class FibonacciFinder
    {
        public long RecurtionFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }

            return RecurtionFibonacci(number - 1) + RecurtionFibonacci(number - 2);
        }

        public long IterationFibonacci(int number)
        {
            long a = 1;
            long b = 1;


            for (int i = 2; i < number; i++)
            {
                long temp = a;
                a = a + b;
                b = temp;
            }

            return a;
        }

    }
}
