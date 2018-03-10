using Entitas;

public class UnitySystems {

    private Systems _systems;

    public UnitySystems(Contexts contexts, UnityManagers managers) {
        _systems = new Feature("Unity Systems")
            .Add(new TestSystem(managers.Test));
    }

    public Systems GetSystems() {
        return _systems;
    }

}
