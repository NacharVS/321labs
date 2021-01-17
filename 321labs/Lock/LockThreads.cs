using System;
using System.Collections.Generic;
using System.Threading;

namespace _321labs.Lock
{
    class LockThreads
    {
        static int[] firstArray = new int[10];
        static int[] secondArray = new int[10];
        static int[] sumArray = new int[10];
        object locker = new object();
        Thread firstArrayElem;
        Thread secondArrayElem;
        Thread sumArrayElem;
        Random rnd = new Random();

        public void GenerateFirstArray()
        {
            lock (locker)
            {
                Console.Write("First: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = rnd.Next(0, 9);
                }
                foreach (var item in firstArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public void GenerateSecondArray()
        {
            lock (locker)
            {
                Console.Write("Second: ");
                for (int i = 0; i < secondArray.Length; i++)
                {
                    secondArray[i] = rnd.Next(0, 9);
                }
                foreach (var item in secondArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public void GenerateSumArray()
        {
            lock (locker)
            {
                Console.Write("Sum: ");
                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = firstArray[i] + secondArray[i];
                }
                foreach (var item in sumArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        public void StartThreads()
        {
            firstArrayElem = new Thread(new ThreadStart(GenerateFirstArray));
            secondArrayElem = new Thread(new ThreadStart(GenerateSecondArray));
            sumArrayElem = new Thread(new ThreadStart(GenerateSumArray));
            firstArrayElem.Start();
            secondArrayElem.Start();
            sumArrayElem.Start();
        }
    }
}
