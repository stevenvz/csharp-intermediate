using System;

namespace Exercises_S2_L15_1
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;

        //to prevent stopwatch from being started twice
        private bool _isRunning;
        
        //start method
        public string Start()
        {
            if (!_isRunning)
            {
                _start = DateTime.Now;
                _isRunning = true;
                return "Stopwatch started @ " + _start;
            }
            else
            {
                //exercise specifications directed the below behavior, otherwise I would have 
                //simply informed the user & continued the main loop
                throw new InvalidOperationException("Stopwatch has already been started.");
            }
        }

        //stop method
        public string Stop()
        {
            if (_isRunning)
            {
                _stop = DateTime.Now;
                _isRunning = false;
                return (_stop - _start).ToString();
            }
            else
            {
                //exercise specifications directed the below behavior, otherwise I would have 
                //simply informed the user & continued the main loop
                throw new InvalidOperationException("Stopwatch has not been started.");
            }
        }

    }
}