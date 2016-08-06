using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TenthTask
{
    public delegate void ClockDelegete();

    class ClockEvent
    {
        public event ClockDelegete Event;

        public void OnClockEvent()
        { 
            Event();
        }
    }
}
