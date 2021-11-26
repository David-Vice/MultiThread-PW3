using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SP_MultiThread_Console
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region without Params
            //ThreadStart start = new ThreadStart(Hello);
            //Thread thread = new Thread(start);
            //thread.Priority = ThreadPriority.Highest;
            //thread.Start();
            #endregion

            #region with Params
            /*
            ParameterizedThreadStart start = new ParameterizedThreadStart(HelloWithName);

            Thread thread1 = new Thread(start);
            thread1.Start("Javid");
            Console.WriteLine(thread1.GetHashCode()); // thread id

            //Process process = Process.GetCurrentProcess();
            //for (int i = 0; i < process.Threads.Count; i++)
            //{
            //    ProcessThread thread = process.Threads[i];
            //    Console.WriteLine(thread.Id);
            //}
            */
            #endregion

            int tasknum = -1;
            while (tasknum != 0)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~");
                Console.WriteLine("1. Task1");
                Console.WriteLine("2. Task2");
                Console.WriteLine("3. Task3");
                Console.WriteLine("4. Task4+Task5");
                Console.WriteLine("~~~~~~~~~~~~~~~~");
                Console.WriteLine("6. WinForm Task6");
                Console.WriteLine("7. WinForm Task7");
                Console.WriteLine("~~~~~~~~~~~~~~~~");
                Console.WriteLine("0. Exit");
                Console.WriteLine("~~~~~~~~~~~~~~~~");
                Console.Write("Enter task number: ");
                tasknum = Convert.ToInt32(Console.ReadLine());
                switch (tasknum)
                {
                    case 1:
                        ThreadStart start1 = new ThreadStart(Count);
                        Thread thread1 = new Thread(start1);
                        thread1.Start();
                        break;
                    case 2:
                        ThreadStart start2 = () => CountRange(1, 50);
                        Thread thread2 = new Thread(start2);
                        thread2.Start();
                        break;
                    case 3:
                        int numthreads;
                        Console.Write("Enter number of threads: ");
                        numthreads = Convert.ToInt32(Console.ReadLine());

                        List<ThreadStart> listStarts = new List<ThreadStart>();
                        List<Thread> listThreads = new List<Thread>();
                        for (int i = 0; i < numthreads; i++)
                        {
                            Console.Write($"Enter start for thread {i + 1}: ");
                            int start = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"Enter end for thread {i + 1}: ");
                            int end = Convert.ToInt32(Console.ReadLine());
                            listStarts.Add(() => CountRange(start, end));
                            listThreads.Add(new Thread(listStarts[i]));
                        }
                        for (int i = 0; i < numthreads; i++)
                        {
                            listThreads[i].Start();
                        }
                        break;
                    case 4:
                        StreamWriter writetext = new StreamWriter("result.txt");
                        writetext.Close();
                        List<int> list = new List<int>();
                        Random rand = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            list.Add(rand.Next(100));
                        }
                        AddList(list);
                        Thread thread3 = new Thread(() => Min(list));
                        thread3.Start();
                        Thread.Sleep(100);
                        Thread thread4 = new Thread(() => Median(list));
                        thread4.Start();
                        Thread.Sleep(100);
                        Thread thread5 = new Thread(() => Max(list));
                        thread5.Start();
                        break;
                    case 6:
                        {
                            string thisDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SP MultiThread PW3 Task6\\bin\\Debug\\netcoreapp3.1\\SP MultiThread PW3 Task6.exe";
                            Process.Start(thisDir);
                        }
                        break;
                    case 7:
                        {
                            string thisDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SP MultiThread PW3 Task7\\bin\\Debug\\netcoreapp3.1\\SP MultiThread PW3 Task7.exe";
                            Process.Start(thisDir);
                        }
                        break;
                    default:
                        break;
                }

                Thread.Sleep(100);
                Console.Write("Click ENTER to continue...");Console.ReadLine();
                Console.Clear();
            }
        }

        private static void HelloWithName(object obj)
        {
            string name = Convert.ToString(obj);
            Console.WriteLine($"\t\tHello {name}!");
        }
        private static void Hello()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("--Hello from Thread!");
            }
        }
        private static void Count()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void CountRange(int num1, int num2)
        {
            for (int i=num1;i<=num2;i++)
            {
                Console.WriteLine(i);
            }
        }
        private static async void Min(List<int> list)
        {
            double min = list.Min();
            Console.WriteLine($"Min: {min}");
            using(StreamWriter writetext = new StreamWriter("result.txt", append: true))
            {
                char[] arr = ("Min: " + Convert.ToString(min)).ToCharArray();
                await writetext.WriteLineAsync(arr);
            }
        }
        private static async void Median(List<int> list)
        {
            double avg = list.Average();
            Console.WriteLine($"Median: {avg}");
            using (StreamWriter writetext = new StreamWriter("result.txt", append: true))
            {
                char[] arr = ("Median: " + Convert.ToString(avg)).ToCharArray();
                await writetext.WriteLineAsync(arr);
            }
        }
        private static async void Max(List<int> list)
        {
            double max = list.Max();
            Console.WriteLine($"Max: {max}");
            using (StreamWriter writetext = new StreamWriter("result.txt", append: true))
            {
                char[] arr = ("Max: " + Convert.ToString(max)).ToCharArray();
                await writetext.WriteLineAsync(arr);
            }
        }
        private static async void AddList(List<int> list)
        {
            using (StreamWriter writetext = new StreamWriter("result.txt", append: true))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    char[] num = Convert.ToString(list[i]).ToCharArray();
                    await writetext.WriteLineAsync(num);
                }
            }
        }
    }
}
