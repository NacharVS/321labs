using System;
using System.Threading.Tasks;

namespace _321labs.Kamalov.asyncStart
{
    class asyncStart
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] result = new int[10];
        static Random rnd = new Random();




        private static void GenerateValue(int[] arr)
        {
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }

       

    }
}

