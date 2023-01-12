using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask
{
    internal class NumberTask
    {
        internal int[] EnterArrays()
        {
            Console.Write("Massivin elementlerin daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"mass[{i}]=");
                mass[i] = int.Parse(Console.ReadLine());
            }
            return mass;

        }

        internal int[] GetSqrtElements(int[] mass)
        {
            int count = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                    count++;
            }

            int[] sqrtElements = new int[count];
            int index = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                {
                    sqrtElements[index++] = mass[i];
                }
            }

            return sqrtElements;
        }

        internal void Print(int[] mass)
        {
            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
        }
    }
}



