using System;

namespace Effects.LifetimeHandler
{
    public class TimedLifetimeHandler : ILifetimeHandler
    {
        private DateTime _startTime;
        private TimeSpan _timePassed;
        private TimeSpan _duration;

        public DateTime StartTime => _startTime;
        public TimeSpan TimeLeft => _duration - _timePassed;
        public TimeSpan TimePassed => _timePassed;
        public TimeSpan Duration => _duration;

        public event Action OnTimeOut;

        public TimedLifetimeHandler(TimeSpan duration)
        {
            _startTime = DateTime.Now;
            _timePassed = TimeSpan.Zero;
            _duration = duration;
        }

        public void Update()
        {
            _timePassed = DateTime.Now - _startTime;

            if (_timePassed >= _duration)
            {
                OnTimeOut?.Invoke();

                return;
            }
        }
    }
}