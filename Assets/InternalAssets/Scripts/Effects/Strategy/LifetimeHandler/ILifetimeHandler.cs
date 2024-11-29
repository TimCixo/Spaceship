using System;

public interface ILifetimeHandler
{
    public DateTime StartTime { get; }
    public TimeSpan TimeLeft { get; }
    public TimeSpan TimePassed { get; }
    public TimeSpan Duration { get; }
    public event Action OnTimeOut;

    public void Update();
}