using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;

namespace _321labs
{
    class Program
    {

        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenForTask1 = new CancellationTokenSource();
            CancellationTokenSource cancellationTokenForTask2 = new CancellationTokenSource();
            CancellationTokenSource cancellationTokenForTask3 = new CancellationTokenSource();
            Task task1 = new Task(() =>
            {
                if (cancellationTokenForTask1.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция по сумме не запускается");
                    return;
                }

                Random random = new Random();
                int result = 0;
                for (int i = 0; ; i++)
                {
                    result += random.Next(1, 100);
                    Console.WriteLine(result);
                    Thread.Sleep(1000);
                }
            });
            Task task2 = new Task(() => 
            {
                if (cancellationTokenForTask2.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция по генерации рандомных чисел не запускается");
                    return;
                }
                Random random = new Random();
                for (int i = 0; ; i++)
                {
                    Console.WriteLine(random.Next(1, 100));
                }
            });
            Task task3 = new Task(() =>
            {
                if (cancellationTokenForTask3.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция по вычислению корня не запускается");
                    return;
                }
                Random random = new Random();
                for (int i = 0; ; i++)
                {
                    Console.WriteLine(Math.Sqrt(random.Next(1, 100)).ToString("0.00"));
                }
            });
            task1.Start();
            task2.Start();
            task3.Start();

            task1.Wait();
            task2.Wait();
            task3.Wait();
        }
       
       
    }
}
