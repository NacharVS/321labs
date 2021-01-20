using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Lovkov
{
    class ContinuationTasks
    {
        static int[] mass = new int[20];
        int massproduct = 1;

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
        public void ProductMass(Task t)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                massproduct *= mass[i];
            }
        }
        public void EvenMass(Task t)
        {
            string stringProd = massproduct.ToString();
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
        public void TaskStarter()
        {
            Task RandomMas = new Task(RandomMass);
            Task prodv = RandomMas.ContinueWith(ProductMass);
            Task evendig = prodv.ContinueWith(EvenMass);
            RandomMas.Start();

            evendig.Wait();
        }
        //    static void Main(string[] args)
        //    {
        //       

        //    }
        //}
    }
}
