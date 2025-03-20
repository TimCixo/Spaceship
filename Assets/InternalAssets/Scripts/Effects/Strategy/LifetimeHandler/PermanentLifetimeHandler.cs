#pragma warning disable CS0067
using System;

namespace Effects.LifetimeHandler
{
    public class PermanentLifetimeHandler : ILifetimeHandler
    {
        private DateTime _startTime;
        private TimeSpan _timePassed;

        public DateTime StartTime => _startTime;
        public TimeSpan TimeLeft { get; }
        public TimeSpan TimePassed => _timePassed;
        public TimeSpan Duration { get; }

        public event Action OnTimeOut;

        public PermanentLifetimeHandler()
        {
            _startTime = DateTime.Now;
            _timePassed = TimeSpan.Zero;
        }

        public void Update()
        {
            _timePassed = DateTime.Now - _startTime;
        }
    }
}