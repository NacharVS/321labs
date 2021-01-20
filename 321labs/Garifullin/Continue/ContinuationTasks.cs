using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Garifullin.Continue
{
    class ContinuationTasks
    {
        static int[] mas = new int[20];
        long prod = 1;

        public void MassFull()
        {
            Random rand = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 10);
                Console.WriteLine($"{i + 1} элемент массива {mas[i]}");
            }
            Console.WriteLine();
        }
        public void Product(Task t)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                prod *= mas[i];
            }
            Console.WriteLine($"Произведение элементов: {prod}\n");
        }
        public void Evendigits(Task t)
        {
            string stringProd = prod.ToString();
            char[] element = new char[stringProd.Length];
            for (int i = 0; i < element.Length; i++)
            {
                element[i] = stringProd[i];
            }
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < element.Length; i++)
            {
                if ((int)char.GetNumericValue(element[i]) % 2 == 0 && (int)char.GetNumericValue(element[i]) != 0)
                {
                     evenNumbers.Add((int)char.GetNumericValue(element[i]));
                }
            }
            Console.Write($"Even numbers from product: ");
            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");
            }
        }

        public void StartThreads()
        {
            Task full = new Task(MassFull);
            Task prodv = full.ContinueWith(Product);
            Task evendig = prodv.ContinueWith(Evendigits);
            full.Start();

            evendig.Wait();
        }
    }
}
