using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask
{
    internal class NumbersTask
    {
        internal int Enternumbers()
        {
            Console.Write("Enter the number:");
            int n = int.Parse(Console.ReadLine());  
            return n;
        }
        internal int GetReverseNumber(int number)
        {
            int reversenumber = 0;
            int n = (int)Math.Log10(number);
            int r;
            while (number!= 0)
            { r = number % 10;
                reversenumber += r * (int)Math.Pow(10, n--);
                number /= 10;
            }
            return reversenumber;
        }
    }
}
