using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace _321labs
{
    class CancellationTokenEx
    {
        Random rnd = new Random();
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
      
        int x;
        int y;
        int a;
        int f=0;

        public void Summ()
        {
            CancellationToken Token = cancellationTokenSource.Token;
            a = rnd.Next(1,5);
            y = rnd.Next(1,5);
            x = rnd.Next(1,5);
            Console.WriteLine($"Элемент а = {a}, Элемент у ={y}, Элемент х ={x}");
            int g = a + y + x;
            for (int i = 0; i < g; i++)
            {
                if (Token.IsCancellationRequested)
                {
                    
                    return;
                }
                f++;
                Console.WriteLine(f);
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Количество итераций цикла = {f}");
        }
        public void Array()
        {
            CancellationToken Token1 = cancellationTokenSource.Token;
            int[] g = new int[5];
            for (int i = 0; i < g.Length; i++)
            {
                if (Token1.IsCancellationRequested)
                {
                    return;
                }
                g[i] = rnd.Next(1, 20);
                Console.WriteLine($"Добавлен элемент {g[i]}");
                Thread.Sleep(1000);
            }
        }
        public void Product()
        {
            CancellationToken Token2 = cancellationTokenSource.Token;
            x = 10;
            y = rnd.Next(1,5);
            for (int i = 0; i < y; i++)
            {
                if (Token2.IsCancellationRequested)
                {
                    return;
                }
                x *= 10;
                Console.WriteLine(x);
            }

        }
        public void Start()
        {
            Task task = new Task(Summ);
            task.Start();
            
          
            Task task1 = new Task(Array);
            task1.Start();

            Task task2 = new Task(Product);
            task2.Start();

            string s = Console.ReadLine();
            if (s == "1")
            {
                Console.WriteLine("Операция остановлена");
                cancellationTokenSource.Cancel();

            }
            string s1 = Console.ReadLine();
            if (s1 == "2")
            {
                Console.WriteLine("Операция остановлена");
                cancellationTokenSource.Cancel();

            }
            string s2 = Console.ReadLine();
            if (s2 == "3")
            {
                Console.WriteLine("Операция остановлена");
                cancellationTokenSource.Cancel();

            }

        }
    }
}
