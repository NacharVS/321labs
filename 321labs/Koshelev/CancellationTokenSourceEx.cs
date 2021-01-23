using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs.Koshelev
{
    class CancellationTokenSourceEx
    {

        static void SumRandomNumbers(CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция не запуститься");
                return;
            }

            Random random = new Random();
            int result = 0;
            for (int i = 0; ; i++)
            {
                result += random.Next(1, 100);
                Console.WriteLine(result);
            }
        }
        static void RandomGanerationNumbers(CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция не запуститься");
                return;
            }
            Random random = new Random();
            for (int i = 0; ; i++)
            {
                Console.WriteLine(random.Next(1, 100));
            }

        }
    }
}
