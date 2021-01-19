using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class ContinuationTasks
    {
        int[] array = new int[20];
        int product = 1;
        public void GenerateArray()
        {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 20);
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
            Console.WriteLine("Умножение ахах: "+ product);
        }
        
        public void EvenProduct()
        {
            string number = Convert.ToString(product);
            char[] dig_mas = new char[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                dig_mas[i] = number[i];
                Console.WriteLine(dig_mas[i]);

            }
        }

        public void Start()
        {
            GenerateArray();
            ProductArray();
            EvenProduct();

        }

    }
}
