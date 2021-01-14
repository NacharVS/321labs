//using _321labs.Kamalov.Threads;
//using System.Threading;

//namespace _321labs.Kamalov.Thread
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] test = { 3123, 165, 2123, 464, 7, -22, 512 };

//            CustomThreads arr = new CustomThreads();
//            Threads test1 = new Threads(new ParameterizedThreadStart(arr.Total));
//            Threads test2 = new Threads(new ParameterizedThreadStart(arr.Maximum));
//            Threads test3 = new Threads(new ParameterizedThreadStart(arr.Sort));

//            test1.Start(test);
//            test2.Start(test);
//            test3.Start(test);
//        }
//    }
//}