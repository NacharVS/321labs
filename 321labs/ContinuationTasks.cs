using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace _321labs
{
    class ContinuationTasks
    {
        int[] array = new int[20];
        static Random rnd = new Random();

        public void Generator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 5);
            }

            Console.Write("Elements array: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Product()
        {
            int sum = 1;
            int even = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum *= array[i];
            }
            Console.WriteLine("Sum elements array: {0}",sum);

            Console.WriteLine("Even digit: ");
            while (sum % 10 != 0)
            {
                if (true)
                {

                }
            }
            
            

        }

        //public void EvenDigit()
        //{
        //    int evenDigit = 0;
        //    while ()
        //    {

        //    }
        //}
    }
}
