using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;

namespace _321labs
{
    class Program
    {
        static object locker = new object();
        private static int[] mas1 = new int[10];
        private static int[] mas2 = new int[10];
        private static int[] mas3 = new int[10];

        static void Main(string[] args)
        {
            RandomIntNumForMas1(mas1);
            RandomIntNumForMas2(mas2);
            SumMas();
            Console.ReadKey();
        }
        static async void RandomIntNumForMas1(int[] mas)
        {
            await Task.Run(() =>
            {
                Random random = new Random();
                lock(locker)
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = random.Next(0, 50);
                    }
                }
            });
        }
        static async void RandomIntNumForMas2(int[] mas)
        {

            await Task.Run(() =>
            {
                Random random = new Random();
                lock(locker)
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = random.Next(0, 50);
                    }
                }
            });
        }
        static async void SumMas()
        {
            await Task.Run(() =>
            {
                Console.Write("MasResult: ");
                for (int i = 0; i < mas3.Length; i++)
                {
                    mas3[i] = mas1[i] + mas2[i];
                    Console.Write(mas3[i] + ", ");
                }
            });
        }
    }
}
