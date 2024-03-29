﻿using System.Runtime.CompilerServices;

public class MyStopwatch
{
    private DateTimeOffset _start;
    private DateTimeOffset _stop;
    private TimeSpan _interval;
    private bool _isRunning = false;

    public void Start()
    {
        if (_isRunning)
        {
            throw new InvalidOperationException("Timer already running.");
        }
        _start = DateTimeOffset.Now;
        _isRunning = true;
    }
    public void Stop()
    {
        if (_isRunning)
        {
            _stop = DateTimeOffset.Now;
        }
        else
        {
            throw new InvalidOperationException("Start the timer first.");
        }

    }
    public TimeSpan GetInterval()
    {
        if (_interval == default)
        {
            throw new InvalidOperationException("Start and stop the stopwatch to measure the time first.");
        }
        else
        {
            _interval = _stop - _start;
            return _interval;
        }
    }
}