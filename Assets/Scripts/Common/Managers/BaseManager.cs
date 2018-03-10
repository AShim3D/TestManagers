public class BaseManager {

    protected readonly IGameManagers _managers;
    
    Contexts Contexts {
        get {
            return _managers.Contexts;
        }
    }

    public BaseManager(IGameManagers managers) {
        _managers = managers;
    }

}
