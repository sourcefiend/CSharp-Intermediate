using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private TimeSpan _endTime;
        private bool _isRunning = false;
        private int _numOfSession = 0;

        public Stopwatch()
        {

        }

        public void Start()
        {
            if (_isRunning)
                throw new System.InvalidOperationException("The stopwatch is already running.");

            _startTime = DateTime.Now; 
            _isRunning = true;     
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new System.InvalidOperationException("The stopwatch is not currently running.");

            _numOfSession++;
            _endTime = DateTime.Now - _startTime;
            Console.WriteLine("Session {0} : Time elapsed: {1} \n", _numOfSession, _endTime);
            _isRunning = false;
        }
    }
}
