using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _321labs.Canseltas
{
    
    class CancelTasks
    {
       static  CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
       static CancellationToken token = cancelTokenSource.Token;
       static int number = 6;

        Task task1 = new Task(() =>
        {
            int result = 0;
            for (int i = 0; i > result; i++)
            {
                if (token.IsCancellationRequested)
                 {
                                Console.WriteLine("task cancel");
                                return;
                 }
            }

            result = number + number;
            Console.WriteLine($"Сумма чисел равна {result} ") ;
            Thread.Sleep(3000);


        });

        


        Task task2 = new Task(() =>
        {




        });


        Task task3 = new Task(() =>
        {




        });
        public void start()
        {
            task1.Start();
            Console.WriteLine("Введите Y для отмены операции или другой символ для ее продолжения:");
            string s = Console.ReadLine();
            if (s == "Y")
            {
cancelTokenSource.Cancel();
                Console.WriteLine("task cancel");
            }
                

            Console.Read();

        }
    }
}
