using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Gossiping
    {
        public delegate void delegatePrint(string msg);
        public delegatePrint _delegatePrint;
        public void Post(string msg)
        {
            _delegatePrint.Invoke(msg);
        }


        // Action是基於委派的實作，不帶傳回值。
        // Action<T1,T2,....>
        public void Notify(Action<string> action, string news)
        {
            action(news);
        }

        // Func是基於委派的實作，帶傳回值
        // Func<T1,....,TResult>
        public string PrintHowPeople(Func<int,string> func, int count)
        {
            return func(count);
        }
    }
}
