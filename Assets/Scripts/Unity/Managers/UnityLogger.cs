using UnityEngine;

public class UnityLogger : BaseManager, ILoggerManager {

    public UnityLogger(IGameManagers managers) : base(managers) {}

    public void PrintLn(string message) {
        Debug.Log(message);
    }

}
