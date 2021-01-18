using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace _321labs
{
    class Tasks
    {
        static int[] array = new int[10];
        static int[] array2 = new int[10];
        static int[] resultArray = new int[10];
        object x= new object();
        public void GenerateArray()
        {
            lock (x)
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Первый массив");
                foreach (var item in array)
                {
                    Console.WriteLine(item + " ");

                }
                
            }
        }
        public void GenerateArray2()
        {
            lock (x)
            {

                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array2[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Второй массив");
                foreach (var item in array2)
                {
                    Console.WriteLine(item + " ");

                }
               
            }
        }

        public void SumOfArrays()
        {
            lock (x)
            {

                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = array[i] + array2[i];

                }
                Console.WriteLine("Сумма");
                foreach (var item in resultArray)
                {
                    Console.WriteLine(item + " ");

                }
                
            }
        }
        public void Start()
        {
            Task task = new Task(GenerateArray);
            Task task1 = new Task(GenerateArray2);
            Task task2 = new Task(SumOfArrays);
           
            task.Start();
            task.Wait();
            task1.Start();
            task1.Wait();
            task2.Start();
            
          

        }


    }
}
