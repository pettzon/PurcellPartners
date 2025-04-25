namespace PurcellPartners_1.Service.Implementation;

public class Logger : ILogger
{
    public void LogMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}