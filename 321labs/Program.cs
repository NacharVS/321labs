using _321labs.Mironov.Thread;
using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Leave hope behind all who enters here....");
            int[] arr = new int [] {1,6,84,5,6,783,21,468132,5423 };
            ThreadArr threadArr = new ThreadArr(arr);
            Thread thread1 = new Thread(new ParameterizedThreadStart(threadArr.MaxArr));
            Thread thread2 = new Thread(new ParameterizedThreadStart(threadArr.MaxArr));
            Thread thread3 = new Thread(new ParameterizedThreadStart(threadArr.MaxArr));

        }
    }
}
