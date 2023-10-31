using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        var message = logLine.Split(":")[1].Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        var level = logLine.Split(":")[0].Trim().ToLower().Replace("[","").Replace("]","");
        return level;
    }

    public static string Reformat(string logLine)
    {
       var log  = logLine.Split(":");
       return $"{log[1].Trim()} ({log[0].ToLower().Trim().Replace("[","").Replace("]","")})";
    }
}
