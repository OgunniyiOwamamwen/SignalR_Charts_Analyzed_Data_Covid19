using System;
using System.Threading;

namespace SignalR_Charts_Core_5_0.TimerFeature
{
    public class TimerManager
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private Action _action;

        public DateTime TimerStarted { get; set; }


        public TimerManager( Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(Execute, _autoResetEvent, 1000, 2000);
            TimerStarted = DateTime.Now;
        }

        // Add  
        public void Execute(object stateInfo)
        {
            _action();

            if((DateTime.Now - TimerStarted).Seconds > 60)
            {
                // Destructor
                _timer.Dispose();
            }
        }

    }
}
