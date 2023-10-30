public class LogLevels {
    
    public static String message(String logLine) {
        var a = logLine.lastIndexOf(":")+1;
        return logLine.substring(a).trim();
    }
    public static String logLevel(String logLine) {
        var b = logLine.lastIndexOf("[")+1;
        var c = logLine.lastIndexOf("]");
        return logLine.substring(b,c).trim().toLowerCase();
    }
    public static String reformat(String logLine) {
        var a = logLine.lastIndexOf(":")+1;
        var message = logLine.substring(a).trim();
        var b = logLine.lastIndexOf("[")+1;
        var c = logLine.lastIndexOf("]");
        var level = logLine.substring(b,c).trim().toLowerCase();
        return message+" ("+level+")";
    }
}
