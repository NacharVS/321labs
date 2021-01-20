using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.ContinuationTasks
{
     public class ContinuationTask
    {
        public  static int[] arr1 = new int [20];
        public  static void MainTask()
        {

            Task task = new Task(() => RandomArr1());
            task.Start();
            Task task1 = task.ContinueWith(rand => Product());
            Task task2 = task1.ContinueWith(even => Even());
            
            Task.WaitAll(task,task1,task2);
        }
        public static void RandomArr1()
        {
                for (int i = 0; i < arr1.Length; i++)
                {
                    Random random = new Random();
                    arr1[i] = random.Next(1,20);
                    Console.WriteLine("Random: "+ arr1[i]);                  
                }
        }
        public static void Product()
        {

            long proz = 1;
            for (int i = 0; i < arr1.Length; i++)
            {
                proz=arr1[i]*proz;
                
            }
            Console.WriteLine("product " + proz);
            
        }
        public static void Even() 
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i]%2==0)
                {
                    Console.WriteLine("Even "+arr1[i]);
                }
            }
        }

    }
}
