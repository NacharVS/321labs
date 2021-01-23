using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class CancellationTokenEx
    {
        int[] array = new int[20];

        public void Start()
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            CancellationToken token = cancellationToken.Token;
            

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
