using System;
using System.Threading;

namespace _321labs.Treads
{
    class Threads
    {
        int[] array;

        public Threads(int[] mass)
        {
            array = mass;
        }
        void M()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            Console.WriteLine("Max=" + max);
        }

        void S()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine("Sum=" + sum);
        }

        void Sort()
        {
            Array.Sort(array);
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
        public void Start()
        {
            Thread threadM = new Thread(new ThreadStart(M));
            Thread threadS = new Thread(new ThreadStart(S));
            Thread threadSort = new Thread(new ThreadStart(Sort));
            threadM.Start();
            threadS.Start();
            threadSort.Start();
        }
    }
}