using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 4, 6, 321, 241, 213, 521 };
            ThreadUltimate thread = new ThreadUltimate(array);
            thread.ThreadStart();
        }
    }
}
