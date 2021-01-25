using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _321labs.CancellationTokenEx
{
    class CancellationTokenEx
    {
        public  static void MainCancellationTokenEx()
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();

            CancellationToken token = cancellationToken.Token;
            Task task1 = new Task(() =>
            {
                int summ = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    summ += i;
                    Thread.Sleep(2000);
                   

                }
                Console.WriteLine("Сумма: "+summ);

            });
            task1.Start();
            



            Task task2 = new Task(() =>
            {
                int fac=1;
                for (int i = 1; i <=10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    fac *=i;
                    Thread.Sleep(3000);
                    Console.WriteLine("факториал числа 10  : " + fac);
                    
                }
                 
               

            });
            task2.Start();
            
            Task task3 = new Task(() =>
            {
                long summ = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    Random n = new Random();
                    summ += n.Next(0,10);
                    Thread.Sleep(4000);
                    Console.WriteLine(summ);
                }
            });
            task3.Start();

            Console.WriteLine("Введите l для отмены операции или другой символ для ее продолжения:");
            string s = Console.ReadLine();
            if (s == "l")
                cancellationToken.Cancel();

            Task.WaitAll(task1, task2, task3);
            Task[] tasks = new Task[3] { task1, task2, task3 };




        }

    }
}
