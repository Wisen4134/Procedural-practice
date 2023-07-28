using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Taiwan
    {

        public Taiwan() 
        {
            Gossiping gossiping = new Gossiping();
            Passenger passenger = new Passenger();

            Passenger 接收者1 = new Passenger() { name = "接收者1" };
            Passenger 接收者2 = new Passenger() { name = "接收者2" };
            Passenger 接收者3 = new Passenger() { name = "接收者3" };

            gossiping._delegatePrint += 接收者1.NotifyMe;
            gossiping._delegatePrint += 接收者2.NotifyMe;
            gossiping._delegatePrint += 接收者3.NotifyMe;

            gossiping.Post("嗨各位");

            Console.WriteLine(gossiping.PrintHowPeople(passenger.FuncTest, 5)); 

            gossiping.Notify(passenger.ReceiveNews, Console.ReadLine());
        }
    }
}
