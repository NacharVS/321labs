using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Mironov
{
    class ContinuationTasks
    {
       private static long[] arr = new long[20];
        static Random rnd = new Random();
        public static void Start()
        {
            

        }
        private  void GenerateValue()
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        private  long MultiplyElem()
        {
            long product=1;
            foreach (var item in arr)
            {
                product *= item;
            }
            return product;
        }
        private void ShowEven(long number)
        {

        }


    }
}
