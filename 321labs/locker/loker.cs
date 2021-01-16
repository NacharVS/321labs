using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.locker
{
    class loker
    {
        public static void Random( int[] array)
        {
            for (int i = 0; i < 10; i++)
            {
                Random ran = new Random();
                array[i] = ran.Next(1, 50);
            }
        }
        public static void Summ(int[] array1, int[] array2)
        {
            
        }
    }
}
