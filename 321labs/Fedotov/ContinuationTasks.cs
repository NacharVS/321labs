using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class ContinuationTasks
    {
        int[] array = new int[20];

        public void Start()
        {
            Task task1 = new Task(Generic);
            Task<int> task2 = task1.ContinueWith(generic => Product());
            Task task3 = task2.ContinueWith(product => ShowEven(product.Result));

            task1.Start();
            task2.Wait();
            task3.Wait();
        }
        void Generic()
        {
            Console.WriteLine("Сгенерировался");
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        int Product()
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
                product *= array[i];
            Console.WriteLine("Умножился: " + product);
            return product;
        }

        void ShowEven(int n)
        {
            if (n < 0) n *= -1;
            Console.WriteLine("Четные цифры:");
            while (n != 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    Console.Write(n % 10 + " ");
                } 
                n /= 10;
            }
        }
    }
}
