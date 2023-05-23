using System;
static class LogLine
{
    public static string Message(string logLine)
    {
        if(logLine.StartsWith("[INFO]"))
		   {
			   return logLine.Remove(0,7).Trim();
		   }
		else if(logLine.StartsWith("[ERROR]"))
			{
				return logLine.Remove(0,8).Trim();
			}
		else if(logLine.StartsWith("[WARNING]"))
			{
				return logLine.Remove(0,10).Trim();
			}
		else
			{
				return ("program failed");
			}
    }
    public static string LogLevel(string logLine)
    {
        if(logLine.StartsWith("[INFO]"))
		   {
			   return "info";
		   }
		else if(logLine.StartsWith("[ERROR]"))
			{
				return "error";
			}
		else if(logLine.StartsWith("[WARNING]"))
			{
				return "warning";
			}
		else
			{
				return ("program failed");
			}
    }
    public static string Reformat(string logLine)
    {
        if(logLine.StartsWith("[INFO]"))
		   {
		   return (logLine.Remove(0,7).Trim()+" (info)");
		   }
		else if(logLine.StartsWith("[ERROR]"))
			{
				return (logLine.Remove(0,8).Trim()+" (error)");
			}
		else if(logLine.StartsWith("[WARNING]"))
			{
				return (logLine.Remove(0,10).Trim()+" (warning)");
			}
		else
			{
				return ("program failed");
			}
    }
}
