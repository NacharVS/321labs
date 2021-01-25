using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace _321labs.CansalationTask
{
    class CansalationProgram
    {
        private int n;
       private int N { get => n; set => n = Math.Clamp(value, 0, 9);  }
       private static List<ConsoleKey> digits = new List<ConsoleKey> { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.D4, ConsoleKey.D5, ConsoleKey.D6, ConsoleKey.D7, ConsoleKey.D8, ConsoleKey.D9 };
       public static void CansalationMain()
        {
            List<CancellationTokenSource> cancellationTokensSource = new List<CancellationTokenSource>();
            List<Task> tasksList = new List<Task>();
            TaskFactory taskFactory = new TaskFactory();
            Console.WriteLine("Сколько нужно запустить тасков? (1-9)");
            int N=0;
            var TaskKey = Console.ReadKey().Key;
            if (digits.Contains(TaskKey))  N = int.Parse(TaskKey.ToString().Substring(1)); 
            else return;
            Console.WriteLine();
            Console.WriteLine("Введите цифру для отмены одного из {0} тасков",N);
            
            for (int i = 0; i < N; i++)
            {
                cancellationTokensSource.Add(new CancellationTokenSource());
                var token = cancellationTokensSource[i].Token;
                tasksList.Add(taskFactory.StartNew((i) => {  while (true) { Thread.Sleep((int)i * 1000); if (token.IsCancellationRequested) { break; }; Console.WriteLine($"Task: {(int)i} Cost: {(int)i*1000}"); } ; }, i+1, cancellationTokensSource[i].Token));
            }

            while (true)
            {
                
                var key = Console.ReadKey(true).Key;
                if (tasksList.All(p => p.IsCompleted)) break;
                else if (digits.Contains(key)&& int.Parse(key.ToString().Substring(1)) - 1<tasksList.Count)
                {
                    int intkey = int.Parse(key.ToString().Substring(1)) - 1;
                    cancellationTokensSource[intkey].Cancel();
                }
                
            } 
            

            
            Task.WaitAll(tasksList.ToArray());

        }
    }
}
