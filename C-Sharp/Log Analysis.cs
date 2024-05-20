using System;
public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int indexOfSpace = str.IndexOf(delimiter)+delimiter.Length;
        string logline = str.Substring(indexOfSpace, str.Length - indexOfSpace);
        return logline;
    }
    public static string SubstringBetween(this string str, string delimit1, string delimit2)
    {
        int index1 = str.IndexOf(delimit1)+delimit1.Length;
		int index2 = str.IndexOf(delimit2)-delimit2.Length;
		string loglevel = str.Substring(index1, index2-index1+delimit2.Length);
		return loglevel;
    }
    
    public static string Message(this string str)
    {
        int indexOfSpace = str.IndexOf(": ")+2;
        string logline = str.Substring(indexOfSpace, str.Length - indexOfSpace);
        return logline;
    }
    public static string LogLevel(this string str)
    {
        int index1 = str.IndexOf("[")+1;
        int index2 = str.IndexOf("]")-1;
        string loglevel = str.Substring(index1, index2);
        return loglevel;
    }
}
