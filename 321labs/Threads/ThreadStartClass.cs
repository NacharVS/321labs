using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    class ThreadStartClass
    {
        public static void Start()
        {
            ThreadSolution solution = new ThreadSolution(new int[] { 1, 2, 5, 2, -24, 12, 23, -43, 35, 24, 67, 32, 1, 2, -2, 34, 2 });
            
            var thr1 = new Thread(new ThreadStart(solution.Sum));
            var thr2 = new Thread(new ThreadStart(solution.Max));
            var thr3 = new Thread(new ThreadStart(solution.Sort));
            thr1.Start();
            thr2.Start();
            thr3.Start();
        }
    }
}
