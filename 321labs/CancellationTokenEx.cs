using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs
{
    class CancellationTokenEx
    {
        Random rnd = new Random();
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        
        Task FirstTask;
        Task SecondTask;
        Task ThirdTask;
        int[] array = { 2, 3, 4, 2, 3, 1, 2, 3, 4, 3 };

        void ArrayProduct()
        {
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
            long product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            Console.WriteLine($"Product of array is: {product}");
            Thread.Sleep(3000);
        }

        
    }
}
