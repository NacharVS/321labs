using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Mironov.Locker
{
    class LockThread
    {
        static int[] arr1 = new int[10];
        static int[] arr2= new int[10];
        static int[] result = new int[10];

        public static void Start()
        {
            for(int i = 0; i < 3; i++)
            {
                Thread myThread = new Thread();
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }
        }


    }
}
