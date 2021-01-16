using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class ThreadLocker
    {
        static Random rnd = new Random();

        static int[] first = new int[10];
        static int[] second = new int[10];
        static int[] third = new int[10];


        public static void GenerateRndDigitFirst()
        {
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = rnd.Next(1, 30);
            }
        }
        public static void GenerateRndDigitSecond()
        {
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = rnd.Next(1, 30);
            }
        }

        public static void SumArray()
        {
            
            for (int i = 0; i < third.Length; i++)
            {
                third[i] = first[i] + second[i];
            }
        }

        public static void Start()
        {

        }
    }
}
