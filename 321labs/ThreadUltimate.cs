using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class ThreadUltimate
    {
        int[] array;

        public int[] Array { get => array; set => array = value; }

        public ThreadUltimate(int[] array)
        {
            this.array = array;
        }

        public void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        public int Max(int[] array)
        {
            return 
        }
    }
}
