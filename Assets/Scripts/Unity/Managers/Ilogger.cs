public interface ILogger {
    ILoggerManager Logger { get; }
}

public interface ILoggerManager {
    void PrintLn(string message);
}