public interface ITest {
    ITestManager Test { get; }
}

public interface ITestManager {
    void Do();
}