using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Model
{
    class StopwatchModel
    {
        private DateTime? _started;
        private TimeSpan? _previousEllapsedTime;
        public TimeSpan? LapTime { get; private set; }
        public bool Running
        {
            get { return _started.HasValue; }
        }
        public TimeSpan? Elapsed
        {
            get
            {
                if (_started.HasValue)
                {
                    if (_previousEllapsedTime.HasValue)
                    {
                        return CalculateTimeElapsedSinceStarted() + _previousEllapsedTime;
                    }
                    else
                    {
                        return CalculateTimeElapsedSinceStarted();
                    }
                }
                else
                {
                    return _previousEllapsedTime;
                }
            }
        }

        private TimeSpan CalculateTimeElapsedSinceStarted()
        {
            return DateTime.Now - _started.Value;
        }
        public void Start()
        {
            _started = DateTime.Now;
            if (!_previousEllapsedTime.HasValue)
            {
                _previousEllapsedTime = new TimeSpan(0);
            }
        }
        public void Stop()
        {
            if (_started.HasValue)
            {
                _previousEllapsedTime += DateTime.Now - _started.Value;
            }
            _started = null;
        }
        public void Reset()
        {
            _previousEllapsedTime = null;
            _started = null;
                LapTime=null;
        }
        public StopwatchModel()
        {
            Reset();
        }
        public void Lap()
        {
            LapTime = Elapsed;
            OnLapTimeUpdated(LapTime);
        }

        public event EventHandler<LapEventArgs> LapTimeUpdated;

        private void OnLapTimeUpdated(TimeSpan? lapTime)
        {
            EventHandler<LapEventArgs> lapTimeUpdated = LapTimeUpdated;
            if (lapTimeUpdated != null)
            {
                lapTimeUpdated(this, new LapEventArgs(lapTime));
            }
        }

    }
}
