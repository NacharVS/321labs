using System;
using System.Threading;

namespace _321labs.Treads
{
    class Threads
    {
        int[] arr;
        Thread summThread;
        Thread maxElemThread;
        Thread sortingThread;
        public int[] Arr { get => arr; set => arr = value; }

        public Threads(int[] array)
        {
            this.arr = array;
        }

        public void StartThreads()
        {
            
        }

        void ElementSum()
        {

        }
    }
}
