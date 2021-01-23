using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs
{
    class CancellationTokenEx
    {
        static int Step2(int x, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прервана токеном");
            }
            x *= x;
            return x;
        }
        static int EvenDigits(int x, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прервана токеном");
            }
            if (x % 2 == 0)
            {
                Console.WriteLine($"Число {x} четное");
            }
            else
            {
                Console.WriteLine($"Число {x} нечетное");
            }
            return x;
        }

    }
}
