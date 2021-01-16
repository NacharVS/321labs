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
            Thread generateValue1 = new Thread(GenerateValueFirst);
            Thread generateValue2 = new Thread(GenerateValueSecond);
            Thread findSum = new Thread();
               

        }

   

        private static void GenerateValueFirst()
        {
            Random rnd = new Random();
          for(int i = 0; i <arr1.Length;i++)
          {
                arr1[i] = rnd.Next();
          }
        }

        private static void GenerateValueSecond()
        {
            Random rnd = new Random();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next();
            }
        }



    }
}
