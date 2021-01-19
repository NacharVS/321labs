using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs
{
    class ContinuationTasks
    {
        int[] array = new int[10];
        int product = 1;
        public void GenerateArray()
        {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 9);
                }
                Console.WriteLine("Массив");
                foreach (var item in array)
                {
                    Console.WriteLine(item + " ");

                }            
        }

        public void ProductArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine("Умножение ахах: " + product);


        }

        public void EvenProduct()
        {
            Console.WriteLine("тут четность");
            string number = Convert.ToString(product);
            char[] dig_mas = new char[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                dig_mas[i] = number[i];
                

            }
            
            int[] buffer = Array.ConvertAll(dig_mas, c => (int)Char.GetNumericValue(c));
            foreach (var item in buffer)
            {
                if (item%2==0)
                {
                    Console.WriteLine(item + " ");
                }
            }

        }

        public void Start()
        {
            Task task = new Task(GenerateArray);
           
            task.ContinueWith(pa =>ProductArray());
            Task task2 = task.ContinueWith(ep => EvenProduct());
            task.Start();
            task.Wait();
            
         

        }

    }
}
