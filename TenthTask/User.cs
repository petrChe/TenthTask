using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TenthTask
{
    class User
    {
        public string Name { get; set; }
        public int SecondsCount { get; set; }

        public User() { }
        public User(string name, int sec)
        {
            Name = name;
            SecondsCount = sec;
        }

        public void BeginCountDown()
        {
            int second = this.SecondsCount * 1000;
            Console.WriteLine("The countdown has begun!!!");
            Thread.Sleep(second);
            Console.WriteLine("Time is up");
        }


    }
}
