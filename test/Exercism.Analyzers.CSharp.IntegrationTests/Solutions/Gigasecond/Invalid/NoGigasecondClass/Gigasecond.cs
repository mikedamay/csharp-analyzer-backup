using System;

public static class NotGigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return new DateTime(moment.Ticks).AddSeconds(1000000000);
    }
}