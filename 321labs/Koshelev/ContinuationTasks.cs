using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Koshelev
{
    class ContinuationTasks
    {
        int[] mas = new int[20];
        long result;
        public int[] Mas { get => mas; set => mas = value; }

        public void RandomElevent()
        {
            Console.Write("Массив");
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(1, 10);
                Console.Write(mas[i] + ", ");
            }
        }

        public void ProductMas()
        {
            result = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                result *= mas[i];
            }

        }

        public void EvenNumbers()
        {
            string resultS = result.ToString();
            Console.WriteLine("Результат = " + result);
            for (int i = 0; i < resultS.Length; i++)
            {
                if (Convert.ToInt32(resultS[i]) % 2 == 0)
                {
                    Console.WriteLine(resultS[i]);
                }
           
            }
        }

    }
}
