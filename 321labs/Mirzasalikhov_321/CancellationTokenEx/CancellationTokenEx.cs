using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace _321labs.Mirzasalikhov_321.CancellationTokenEx
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Процесс {0} запущен", Task.CurrentId);

            for (int count = 0; count < 1000; count++)
            {
                Thread.Sleep(50);
                Console.WriteLine("ID = {0} i= {1}", Task.CurrentId, count);
            }


        }
        public static void Task2()
        {
            Console.WriteLine("Процесс {0} запущен", Task.CurrentId);

            for (int count = 0; count < 100; count++)
            {
                Thread.Sleep(50);
                Console.WriteLine("ID = {0} i= {1}", Task.CurrentId, count);
            }
        }
        public static void Task3()
        {
            Console.WriteLine("Процесс {0} запущен", Task.CurrentId);

            for (int count = 0; count < 00; count++)
            {
                Thread.Sleep(50);
                Console.WriteLine("ID = {0} i= {1}", Task.CurrentId, count);
            }
        }
        public static void Main(String[] args)
        {

            Console.WriteLine("Введите задачи, которые следует выполнить:");
            Console.WriteLine("1- ая задача - выполнять? (yes-да, no-нет)");
            string chose1 = Console.ReadLine();
            Console.WriteLine("2- ая задача - выполнять? (yes-да, no-нет)");
            string chose2 = Console.ReadLine();
            Console.WriteLine("3- ая задача - выполнять? (yes-да, no-нет)");
            string chose3 = Console.ReadLine();
            Task task1 = new Task(Task1);
            if (chose1 == "yes")
            {
                task1.Start();
                task1.Wait();
            }
            Task task2 = new Task(Task2);
            if (chose2 == "yes")
            {
                task2.Start();
                task2.Wait();
            }
            Task task3 = new Task(Task3);
            if (chose3 == "yes")
            {
                task3.Start();
                task3.Wait();
            }

            Console.WriteLine("Основной поток завершен");
            Console.ReadKey();
        }
    }
}