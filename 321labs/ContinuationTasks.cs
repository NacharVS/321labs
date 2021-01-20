using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _321labs
{
    class ContinuationTasks
    {
        int[] array = new int[20];
        long product = 1;
        
        public void GenerateNumbers()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,15);
            }
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
        }
        public void ElementProduct()
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine($"Произведение: {product}");
        }

        public void EvenFromProduct()
        {
            string stringProduct = product.ToString();
            char[] numbers = new char[stringProduct.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = stringProduct[i];
            }
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((int)Char.GetNumericValue(numbers[i])%2==0)
                {
                    evenNumbers.Add((int)Char.GetNumericValue(numbers[i]));
                }
            }
            Console.Write($"Even numbers from product: ");
            foreach (var item in evenNumbers)
            {
                Console.Write(item+" ");
            }
        }
        public void Start()
        {
            Task task = new Task(GenerateNumbers);
            task.ContinueWith(ep => ElementProduct());
            Task task2 = task.ContinueWith(efp => EvenFromProduct());
            task.Start();
            task.Wait();
            task2.Wait();
            
        }
    }
}
