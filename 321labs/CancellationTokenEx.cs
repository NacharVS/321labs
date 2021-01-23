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
                Thread.Sleep(3000);
            }

            Console.WriteLine($"Количество итераций цикла = {f}");
        }
        public void Array()
        {
            int[] g = new int[5];
            for (int i = 0; i < g.Length; i++)
            {
                g[i] = rnd.Next(1, 20);
                Console.WriteLine($"Добавлен элемент {g[i]}");
                Thread.Sleep(3000);
            }
        }
        public void Start()
        {
            //Task task = new Task(Summ);
            //task.Start();
            Task task1 = new Task(Array);
            task1.Start();
            
            
            string s = Console.ReadLine();
            if (s == "s")
            {
                Console.WriteLine("Операция остановлена");
                cancellationTokenSource.Cancel();

            }

        }
    }
}
