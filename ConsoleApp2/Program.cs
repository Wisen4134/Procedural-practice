using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static Random random = new Random();

        /// <summary>
        /// 主程式切入點
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Thread.Sleep(1);
            Algorithm.PrintBubbleSortPractice();
            Thread.Sleep(1);
            DataStructure.PrintStackPractice();
            Thread.Sleep(1);
            DataStructure.PrintQueuePractice();
            Thread.Sleep(1);
            PrintGeneric();

            // 委派練習實例
            Taiwan taiwan = new Taiwan();

            int num = int.Parse(Console.ReadLine());
            PrintNumber print;
            if (num % 2 == 1)
                print = PrintOddNum;
            else
                print = PrintEvenNum;
            print(num);

            Console.Write($"費氏數列驗證，請輸入數字：");
            Console.WriteLine("結果為：" + Algorithm.PrintFibonacci(Int32.Parse(Console.ReadLine())));

            Console.ReadLine();

        }

        private static void PrintGeneric()
        {
            object obj = new object();
            obj = new Card();
            Console.WriteLine($"來看看int ：{PrintSomeType<int>(1)}");
            Console.WriteLine($"來看看string ：{PrintSomeType<string>("字串啦")}");
            Console.WriteLine($"來看看double ：{PrintSomeType<double>(1.5)}");
            Console.WriteLine($"來看看object ：{PrintSomeType<object>(obj)}");

        }



        /// <summary>
        /// 【程式設計概念】泛型
        /// </summary>
        /// <typeparam name="EnterTypeHere"></typeparam>
        /// <param name="para"></param>
        /// <returns></returns>
        private static string PrintSomeType<EnterTypeHere>(EnterTypeHere para)
        {
            return $"泛型應用：{para} 類型為：{typeof(EnterTypeHere)}";
        }

        public delegate void PrintNumber(int num);
        public static void PrintOddNum(int num)
        {
            Console.WriteLine($"奇數：{num}\r\n");
        }
        public static void PrintEvenNum(int num)
        {
            Console.WriteLine($"偶數：{num}\r\n");
        }

        public class Passenger
        {
            public void ReceiveNews(string news)
            {
                Console.WriteLine($"接收者收到：{news}\r\n");
            }
        }
        public class DataStructure
        {
            /// <summary>
            /// 【資料結構】連結串列
            /// </summary>
            public class LinkedList
            {
                public class ListNode
                {
                    public int val;
                    public ListNode next;
                    public ListNode(int val = 0 , ListNode next = null)
                    {
                        this.val = val;
                        this.next = next;
                    }
                }
            }
            /// <summary>
            /// 【資料結構】佇列 FIFO
            /// </summary>
            public static void PrintQueuePractice()
            {
                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < 10; i++)
                {
                    var number = random.Next(1, 100);
                    queue.Enqueue(number);
                    Console.WriteLine($"Queue 放入:{number}");
                }
                int qn = queue.Count;
                for (int i = 0; i < qn; i++)
                {
                    Console.WriteLine($"Queue 拿出來：{queue.Dequeue()}");
                }
                Console.WriteLine("\r\n");
            }

            /// <summary>
            /// 【資料結構】堆疊 FILO
            /// </summary>
            public static void PrintStackPractice()
            {
                Stack<int> Stack = new Stack<int>();
                for (int i = 0; i < 10; i++)
                {
                    var number = random.Next(1, 100);
                    Stack.Push(number);
                    Console.WriteLine($"Stack 放入:{number}");
                }
                int n = Stack.Count;
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine($"Stack 拿出來：{Stack.Pop()}");
                }
                Console.WriteLine("\r\n");
            }
        }

        public class Algorithm
        {

            /// <summary>
            /// 【演算法】費氏數列(斐波那契數列)
            /// </summary>
            /// <param name="n"></param>
            /// <returns></returns>
            public static int PrintFibonacci(int n)
            {
                if (n < 1)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                {
                    return PrintFibonacci(n - 1) + PrintFibonacci(n - 2);
                }

            }

            public static void PrintBubbleSortPractice()
            {
                List<int> SourceList = new List<int>();
                for (int i = 0; i < 20; i++)
                {
                    SourceList.Add(random.Next(1, 1000));
                }
                var Result = BubbleSortArray(SourceList);
                foreach (int i in Result)
                {
                    Console.WriteLine($"{i}\t");
                }
                Console.WriteLine("\r\n");
            }

            /// <summary>
            /// 【演算法】氣泡排序法
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            private static List<int> BubbleSortArray(List<int> item)
            {
                var temp = 0;
                for (int i = 0; i < item.Count - 1; i++)
                {
                    for (int j = 0; j < item.Count - i - 1; j++)
                    {
                        if (item[j] > item[j + 1])
                        {
                            temp = item[j];
                            item[j] = item[j + 1];
                            item[j + 1] = temp;
                        }
                    }
                }


                return item;
            }
        }

        public class Card
        {
            private int _id;
            public int Id
            {
                get { return this._id; }
                set { this._id = value; }
            }
            private string _name;
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            private string _content;
            public string Content
            {
                get { return this._content; }
                set { this._content = value; }
            }

            public Card()
            {
                this._id = 0;
                this._name = string.Empty;
                this._content = string.Empty;
            }


        }

        public class Dual : Card
        {
            private void Attack()
            {
                var s = this.Name;
            }
        }


    }
}
