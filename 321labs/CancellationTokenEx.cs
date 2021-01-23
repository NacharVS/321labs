using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class CancellationTokenEx
    {
        int x = 0;
        int y = 0;
        int z = 0;
        public void Multiplication()
        { 
            Console.WriteLine("Введите число x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число y: ");
            y = Convert.ToInt32(Console.ReadLine());

            z = x * y;
            Console.WriteLine("Произведение: " + z);
        }

        public void Sum()
        {
            z = x + y;
            Console.WriteLine("Сумма чисел Х и У равна: " + z);
        }

        public void Square()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}
