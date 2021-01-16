using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Koshelev
{
    class ThreadLocker
    {
        public int[] mas1 = new int[10];

        public ThreadLocker(int[] mas1)
        {
            this.mas1 = mas1;
        }

        public void RandomNums(int[] mas)
        {
            Random random = new Random();
            for(int i = 0; i < mas.Length)
        }
    }
}
