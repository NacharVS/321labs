using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    public class MyArray
    {
        int[] number = new int [7];

        public MyArray(int [] number)
        {
            this.number = number;
        }

        public void Summ()
        {
            for (int i = 0; i < number.Length; i++)
            {
                int a = 0;
                a += number[i];
                Console.WriteLine(a);
            }
        }

        public void Max()
        {
            for (int i = 0; i < number.Length; i++)
            {
                int a;
                if (a <= number[i])
                {
                    
                }
            }
        }
    }
}
