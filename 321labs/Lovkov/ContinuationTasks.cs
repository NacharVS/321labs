using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Lovkov
{
    class ContinuationTasks
    {
        static int[] mass = new int[20];
        int massproduct;

        public void RandomMass()
        {
            Random rand = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(0, 20);
                Console.WriteLine($"{i + 1} элемент первого массива {mass[i]}");
            }
            Console.WriteLine();
        }
        public void ProductMass()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                massproduct = mass[i] * mass[i + 1];
            }
        }
        public void EvenMass()
        {
            for (int i = 0; i < massproduct; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < mass.Length; j++)
                    {
                        mass[j] = i;
                        Console.WriteLine($"Все чётные числа {mass[j]}");
                    }
                }
            }
        }
        public void TaskStarter()
        {
            Task task1 = new Task(RandomMass);
            Task task2 = new Task(ProductMass);
            Task task3 = new Task(EvenMass);
        }
        //    static void Main(string[] args)
        //    {
        //        ContinuationTasks g = new ContinuationTasks();
        //        Task task4 = new Task(g.RandomMass);
        //        Task task5 = new Task(g.ProductMass);
        //        Task task6 = new Task(g.EvenMass);

        //        task4.Start();
        //        task5.Wait();

        //    }
        //}
    }
}
