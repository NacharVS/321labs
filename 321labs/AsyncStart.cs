using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
namespace _321labs
{
    class AsyncStart
    {
        static int[] firstArray = new int[10];
        static int[] secondArray = new int[10];
        static int[] sumArray = new int[10];
        

        Random rnd = new Random();

        public void GenerateFirstArray()
        {
            Console.Write("First: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = rnd.Next(0, 9);
            }
            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void GenerateSecondArray()
        {
            Console.Write("Second: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = rnd.Next(0, 9);
            }
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void GenerateSumArray()
        {
            Console.Write("Sum: ");
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArray[i] + secondArray[i];
            }
            foreach (var item in sumArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public async void Start()
        {
            await Task.Run(() => GenerateFirstArray());
            await Task.Run(() => GenerateSecondArray());
            await Task.Run(() => GenerateSumArray());
            
        }
    }
}
