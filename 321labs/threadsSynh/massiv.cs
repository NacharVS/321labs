using System;
using System.Threading;

namespace _321labs.Synh
{
    class ThreadLocker
    {
        static int[] array = new int[10];
        static int[] array2 = new int[10];
        static int[] sumArray = new int[10];
        object x = new object();
        object f = new object();
        object b = new object();

        public void GenerateArray1()
        {
            lock (x)
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Первый массив");
                foreach (var item in array)
                {
                    Console.WriteLine(item + " ");

                }

            }
        }
        public void GenerateArray2()
        {
            lock (b)
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Второй массив");
                foreach (var item in array2)
                {
                    Console.WriteLine(item + " ");
                }


            }
        }
       public void Sum()
        {
            lock (f)
            {
                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = array[i] + array2[i];

                }
                Console.WriteLine("Сумма");
            }
            foreach (var item in sumArray)
            {
                Console.WriteLine(item+" ");
            }

        }
        public void start()
        {
            Thread thread1 = new Thread(GenerateArray1);
            Thread thread2 = new Thread(GenerateArray2);
            Thread thread3 = new Thread(Sum);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }

}






