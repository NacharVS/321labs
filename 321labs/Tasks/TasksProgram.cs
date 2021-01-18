using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Tasks
{
    public class TasksProgram
    {
        
            public static void ThreadsMain()
            {
                int[] arr = new int[10] { 1, 2, 33, 44, 5, 3, 2, 4, 2, 4 };
                Task SumTask = new Task(()=>SumIntArray(arr));
                Task MaxTask = new Task(()=>MaxIntArray(arr));
                Task SortTask = new Task(()=>SortIntArray(arr));
                SumTask.Start();
                MaxTask.Start();
                SortTask.Start();
            }

            static void SumIntArray(int[] arr)
            {
                
                    int sum = 0;
                    foreach (int i in arr)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Sum Thread Work Result = {sum}");
                
            }

            static void MaxIntArray(int[] arr)
            {
                
                    int max = arr[0];
                    foreach (int i in arr)
                    {
                        if (max < i)
                        {
                            max = i;
                        }
                    }
                    Console.WriteLine($"Max Thread Work Result = {max}");
                
            }

            static void SortIntArray(int[] arr)
            {

                    Array.Sort(arr);
                    foreach (int i in arr)
                    {
                        Console.WriteLine(i);
                    }
                
            }
    } 
    
}
