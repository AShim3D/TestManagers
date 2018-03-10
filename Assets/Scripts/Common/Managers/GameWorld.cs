using Entitas;

public interface IWorld {
    // Contexts Contexts { get; }
    void Initialize();
    void Execute();
    void Destroy();
}

public class GameWorld : IWorld {

    private Contexts _contexts;
    private Systems _systems;

    public GameWorld(Contexts contexts, Systems systems) {
        _contexts = contexts;
        _systems = systems;
    }

    public void Initialize() {
        _systems.Initialize();
    }

    public void Execute() {
        _systems.Execute();
    }

    public void Destroy() {
        _systems.TearDown();
        _systems.DeactivateReactiveSystems();
        _systems.ClearReactiveSystems();

        _contexts.Reset();
    }

}
