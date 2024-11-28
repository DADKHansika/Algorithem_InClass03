using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourIndexNumber
{
    public class GCDFinder
    {

        public int RecurtionGCD(int number1, int number2)
        {
            if (number2 == 0)
            {
                return number1;
            }

            return RecurtionGCD(number2, number1 % number2);
        }

        public int IterationGCD(int number1, int number2)
        {
            while (number2 != 0)
            {
                int temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }

            return number1;
        }
    }
}
