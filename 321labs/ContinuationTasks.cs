using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class ContinuationTasks
    {

        static int[] numbers = new int[20];
        public static void CreateArray()
        {
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1,20);
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void GetEvenNumvers(Task t)
        {
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if((numbers[i] % 2) == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
