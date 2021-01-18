using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Task_
{
    class TaskThreading
    {
        static int[] array = new int[10];
        static int[] array2 = new int[10];
        static int[] sumArray = new int[10];
        object x = new object();


        Task task1 = new Task(() =>
        {
            
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

        });


       
        Task task2 = new Task(() =>
        {

            {
                Random rnd = new Random();
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Второй массив");
                foreach (var item in array2)
                {
                    Console.WriteLine(item + " ");
                }


            }
        });
        Task task3 = new Task(() =>
        {

            {
                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = array[i] + array2[i];

                }
                Console.WriteLine("Сумма");
            }
            foreach (var item in sumArray)
            {
                Console.WriteLine(item + " ");
            }

        });
        public void start()
        {

            task1.Start();
            task1.Wait();
            task2.Start();
            task2.Wait();
            task3.Start();
            task3.Wait();
           




        }
    }

}






