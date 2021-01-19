using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Koshelev
{
    class ContinuationTasks
    {
        int[] mas;

        public int[] Mas { get => mas; set => mas = value; }

        public ContinuationTasks(int[] mas)
        {
            this.Mas = mas;
        }

        public void RandomElevent()
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(0, 50);
            }
        }

        public void 
    }
}
