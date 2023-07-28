using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Passenger
    {
        public string name;
        public void NotifyMe(string msg)
        {
            Console.WriteLine($"我是{name}，接收：{msg}\r\n");
        }
        public void ReceiveNews(string news)
        {
            Console.WriteLine($"我收到一則新聞內容是:{news}");
        }

        public string FuncTest(int count)
        {
            return $"到底有幾個人：{count}";
        }
    }
}
