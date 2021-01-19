using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class ContinuationTasks
    {
        int[] array = new int[20];
        int product = 1;
        
        public void GenerateNumbers()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 30);
            }
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
        }
        public void ElementProduct()
        {
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine($"Произведение: {product}");
        }

        public void EvenFromProduct()
        {
            string number = Convert.ToString(product);

            //double buffer;
            //List<double> evenNumb = new List<double>();
            //while (number!=0)
            //{
            //    buffer = number % 10;
            //    if (buffer%2 == 0)
            //    {
            //        evenNumb.Add(buffer);
            //        number -= buffer;
            //    }
            //    else
            //    {
            //        number -= buffer;
            //    }
            //}
            //evenNumb.Reverse();
            //foreach (var item in evenNumb)
            //{
            //    Console.WriteLine(item+" ");
            //}
        }
    }
}
