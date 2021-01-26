using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class AsyncStart
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] array3 = new int[10];


        public void Start()
        {
            
        }

        async void GenericArray1()
        {
            await Task.Run(() =>
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array1[i] = rnd.Next(0, 100);
                }
            });
        }

        void GenericArray2()
        {
            lock (new object())
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array2[i] = rnd.Next(0, 100);
                }
            }
        }

        void Summ()
        {
            Console.WriteLine("Thread 1");
            foreach (int item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nThread 2");
            foreach (int item in array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nResult");
            for (int i = 0; i < 10; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
