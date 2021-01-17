using System;
using System.Threading;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Game;

namespace _321labs
{
    class Program
    {
        static int[] mas1 = new int[10];
        static int[] mas2 = new int[10];
        static int[] mas3 = new int[10];
        static object locker = new object();

        static void Main(string[] args)
        {
            
            Warrior warrior = new Warrior();
            Tower tower = new Tower();
            warrior.Attack(tower);
            tower.Blocking();
            Barracks barracks = new Barracks();
            barracks.Notification();
            
        }
        static void RandomIntNumForMas1(int[] mas)
        {
            Random random = new Random();
            lock (locker)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = random.Next(0, 50);
                }
            }
        }
        static void RandomIntNumForMas2(int[] mas)
        {
            Random random = new Random();
            lock (locker)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = random.Next(0, 50);
                }
            }
        }
        static void SumMas()
        {
            Console.Write("MasResult: ");
            for (int i = 0; i < mas3.Length; i++)
            {
                mas3[i] = mas1[i] + mas2[i];
                Console.Write(mas3[i] + ", ");
            }
        }
    }
}
