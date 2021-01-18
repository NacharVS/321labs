using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _321labs.Garifullin.Tasks
{
    class CreateTasks
    {
        int sum;
        int b;
        int temp;
        int[] vs = new int[] { 1, 4, 2, 7 ,8 ,3 ,9};
        public void ArrSum()
        {
            for (int i = 0; i < vs.Length; i++)
            {
                sum += vs[i];
                Console.WriteLine($"Нахождение суммы {sum}");
            }
            Console.WriteLine($"Итого сумма {sum}");
        }
        public void MaxArr()
        {
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] > b)
                {
                    b = vs[i];
                    Console.WriteLine($"Нахождение максимума {b}");
                }
            }
            Console.WriteLine($"Итоговый максимум {b}");
        }
        public void Comparer()
        {
            for (int i = 0; i < vs.Length - 1; i++)
            {
                for (int j = i + 1; j < vs.Length; j++)
                {
                    if (vs[i] > vs[j])
                    {
                        temp = vs[i];
                        vs[i] = vs[j];
                        vs[j] = temp;
                        Console.WriteLine($"Сортировка {vs[i]}");
                        Console.WriteLine($"Сортировка {vs[j]}");
                    }
                }
            }
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine($"Итого сортировки {vs[i]}");
                Thread.Sleep(10);
            }
        }
        public void StartThreads()
        {
            Task sum = new Task(ArrSum);
            Task max = new Task(MaxArr);
            Task compare = new Task(Comparer);
            sum.Start();
            max.Start();
            compare.Start();
            sum.Wait();
            max.Wait();
            compare.Wait();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            CreateTasks createTasks = new CreateTasks();
            createTasks.StartThreads();
        }
    }
}
