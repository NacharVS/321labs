using System;
using System.Threading.Tasks;

namespace _321labs.Kamalov.asyncStart
{
    class asyncStart
    {
        //Start
        public static void Play()
        {
            Generate(mass1);
            Generate(mass2);
            SumMassAsync();
            SortedMassAsync();
        }


        static int[] mass1 = new int[10];
        static int[] mass2 = new int[10];
        static int[] res = new int[10];
        static Random rnd = new Random();

        private static void Generate(int[] arr)
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
        private static async void SortedMassAsync()
        {
            await Task.Run(() => SortedMassAsync());
        }
        private static async void SumMassAsync()
        {
            await Task.Run(() => SumMass());
        }

        private static void SortedMass()
        {
            Console.WriteLine("");

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.WriteLine("");

        }
        private static void SumMass()
        {
            Console.WriteLine("");
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = mass1[i] + mass2[i];
                Console.Write(res[i] + " ");
            }
            Console.WriteLine();
        }
        private static async void GenerateValueAsync(int[] arr)
        {
            await Task.Run(() => Generate(arr));
        }

    }
}