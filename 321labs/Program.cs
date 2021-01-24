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
                
                Random random = new Random();
                int result = 0;
                for (int i = 0; ; i++)
                {
                    if (cancellationTokenForTask1.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция по сумме не запускается");
                        return;
                    }
                    result += random.Next(1, 100);
                    Console.WriteLine("Sum = " + result);
                    Thread.Sleep(1000);
                }
            });
            Task task2 = new Task(() => 
            {
                
                Random random = new Random();
                for (int i = 0; ; i++)
                {
                    if (cancellationTokenForTask2.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция по генерации рандомных чисел не запускается");
                        return;
                    }
                    Console.WriteLine("Random = " + random.Next(1, 100));
                    Thread.Sleep(3000);
                }
            });
            Task task3 = new Task(() =>
            {
                
                Random random = new Random();
                for (int i = 0; ; i++)
                {
                    if (cancellationTokenForTask3.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция по вычислению корня не запускается");
                        return;
                    }
                    Console.WriteLine("Sqrt = " + Math.Sqrt(random.Next(1, 100)).ToString("0.00"));
                    Thread.Sleep(4000);
                }
            });
            task1.Start();
            task2.Start();
            task3.Start();
            if (Console.ReadKey().KeyChar == '1')
            {
                cancellationTokenForTask1.Cancel();
            }
            if (Console.ReadKey().KeyChar == '2')
            {
                cancellationTokenForTask2.Cancel();
            }
            if (Console.ReadKey().KeyChar == '3')
            {
                cancellationTokenForTask3.Cancel();
            }
            task1.Wait();
            task2.Wait();
            task3.Wait();
        }
       
       
    }
}
