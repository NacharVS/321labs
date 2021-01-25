using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    
    class CancellationTokenEx
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static CancellationToken token = cancellationTokenSource.Token;
        static Random random = new Random();
        static int x = random.Next(1, 25);
        static void Step2()
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прервана токеном");
                return;
            }
            else
            {
                int res = x * x;
                Thread.Sleep(1000);
                Console.WriteLine($"{x} * {x} = {res}");
            }
        }

        static void EvenDigits()
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прервана токеном");
                return;
            }
            else if (x % 2 == 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Число {x} четное");
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Число {x} нечетное");
            } 
        }

        static void Procent()
        {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
                else 
                {
                    double procent = x * 0.33;
                    Thread.Sleep(1000);
                    Console.WriteLine($"33 процента от числа {x} равно {procent}");
                }
        }

        public static void Start()
        {
            Task t1 = new Task(Step2);
            Task t2 = new Task(EvenDigits);
            Task t3 = new Task(Procent);
            Console.WriteLine("Нажмите" +
                "\n1 - квадратный корень числа" +
                "\n2 - четное ли число" +
                "\n3 - 33% от рандомного числа" +
                "\n4 - квадратный корень + четное ли число" +
                "\n5 - квадратный корень + 33% от рандомного числа" +
                "\n6 - 33% от рандомнного числа + четное ли число" +
                "\n7 - задействовать все 3 метода");

           
            while(true)
            { 
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        {
                            t1.Start();
                            t1.Wait();
                            break;
                        };
                    case "2":
                        {
                            t2.Start();
                            t2.Wait();
                            break;
                        };
                    case "3":
                        {
                            t3.Start();
                            t3.Wait();
                            break;
                        };
                    case "4":
                        {
                            t1.Start();
                            t2.Start();
                            t1.Wait();
                            t2.Wait();
                            break;
                        }
                    case "5":
                        {
                            t1.Start();
                            t3.Start();
                            t1.Wait();
                            t3.Wait();
                            break;
                        }
                    case "6":
                        {
                            t2.Start();
                            t3.Start();
                            t2.Wait();
                            t3.Wait();
                            break;
                        }
                    case "7":
                        {
                            t1.Start();
                            t2.Start();
                            t3.Start();
                            t1.Wait();
                            t2.Wait();
                            t3.Wait();

                            break;
                        }
                    case "x":
                        {
                            return;
                        }

                    default:
                        break;
                }
            }
        }
    }
}
