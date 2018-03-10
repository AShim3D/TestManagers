public partial class UnityManagers: IGameManagers {

    public Contexts Contexts { get; private set; }

    public UnityManagers(Contexts contexts) {
        Contexts = contexts;
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