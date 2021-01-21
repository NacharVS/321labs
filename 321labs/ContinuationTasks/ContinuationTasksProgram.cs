using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.ContinuationTasks
{
    class ContinuationTasksProgram
    {
        static int[] arr = new int[20];
        public static void ContinuationTasksMain()
        {
            Task task1 = new Task(GenerateRandomToArray);
            Task<long> task2 = task1.ContinueWith(ArrayProduct);
            Task task3 = task2.ContinueWith(ArrayEven);
            task1.Start();
            Task.WaitAll(task1, task2, task3);
        }

        static void GenerateRandomToArray()
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1,10);
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }

        static long ArrayProduct(Task task)
        {
            long product = 1;
            foreach (int i in arr)
            {
                product *= i;
            }
            Console.WriteLine(product);
            return product;
        }

        static void ArrayEven(Task<long> task)
        {
            foreach (char t in task.Result.ToString())
            { 
            if (Convert.ToInt32(t)%2==0)
                    Console.WriteLine(t);
            }
        }
    }
}
