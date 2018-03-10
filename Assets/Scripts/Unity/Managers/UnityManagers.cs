public partial class UnityManagers: IGameManagers {

    readonly Contexts _contexts;

    public UnityManagers(Contexts contexts) {
        _contexts = contexts;
        Logger = new UnityLogger(this);
        Test = new TestManager(this);
    }
}

public partial class UnityManagers: ILogger {
    public ILoggerManager Logger { get; private set; }
}

public partial class UnityManagers: ITest {
    public ITestManager Test { get; private set; }
}