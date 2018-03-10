using Entitas;
using UnityEngine;

public class TestSystem : IExecuteSystem {

    readonly ITestManager _testManager;

    public TestSystem(ITestManager testManager) {
        _testManager = testManager;
    }

    public void Execute () {
        if (Input.GetKeyDown(KeyCode.Space))
            _testManager.Do();
    }

}
