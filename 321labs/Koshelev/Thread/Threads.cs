using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Koshelev.Thread
{
    class Threads
    {
        int[] intNums;

        public Threads(int[] intNums)
        {
            this.intNums = intNums;
        }

        public void SortMas()
        {
            Array.Sort(intNums);
            foreach (int i in intNums)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        public void Max()
        {
            int max = intNums[0];
            foreach (int i in intNums)
            {
                if (max < i)
                    max = i;
            }
            Console.WriteLine("Max = " + max);
        }

        public void SumMas()
        {
            int sum = 0;
            foreach(int i in intNums)
            {
                sum += i;
            }
            Console.WriteLine("Summa mas = " + sum);
        }
    }
}
