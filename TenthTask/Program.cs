using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockEvent clockevent = new ClockEvent();
            User firstUser = new User("Peter",5);
            User secondUser = new User("Victor",3);
            clockevent.Event += delegate ()
            {
                secondUser.BeginCountDown();
                Console.WriteLine("User {0} waited for {1} seconds", firstUser.Name, firstUser.SecondsCount);
            };
            clockevent.Event += () => {
                MessageBox.Show(String.Format("User {0} waited for {1} second", secondUser.Name, secondUser.SecondsCount));
            };
            clockevent.OnClockEvent();
            Console.ReadKey();

        }
    }

}

