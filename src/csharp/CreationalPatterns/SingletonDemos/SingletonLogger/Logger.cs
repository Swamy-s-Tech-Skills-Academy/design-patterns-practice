namespace SingletonLogger;

internal class Logger
{
    private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());

    /// <summary>
    /// Instance
    /// </summary>
    public static Logger Instance
    {
        get
        {
            return _lazyLogger.Value;
        }
    }

    protected Logger()
    {
    }

    /// <summary>
    /// SingletonOperation
    /// </summary> 
    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}
