using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class CancellationTokenExa
    {
        static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        static CancellationToken token = cancelTokenSource.Token;
        static Random random = new Random();
        static int[] arr = new int[10];
        static int sum = 0;
        static int dev = 0;
        static int prod = 0;

        Task taskSum = new Task(() =>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прервана");
                return;
            }
            Console.WriteLine("Arr");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
                Thread.Sleep(500);
            }
        });

        Task taskDev = new Task(() =>
        {

        });

        Task taskProd = new Task(() =>
        {

        });

        public void Start()
        {
            taskSum.Start();

        }
    }
}
