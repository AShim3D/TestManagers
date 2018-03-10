using UnityEngine;

public class TestManager : BaseManager, ITestManager {

    public TestManager(IGameManagers managers) : base(managers) {}

    ILoggerManager Logger {
        get {
            return ((ILogger)_managers).Logger;
        }
    }

    public void Do() {
        Logger.PrintLn("Test");
    }
}
