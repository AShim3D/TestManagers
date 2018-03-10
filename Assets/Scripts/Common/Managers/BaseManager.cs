public class BaseManager {

    protected readonly IGameManagers _managers;

    public BaseManager(IGameManagers managers) {
        _managers = managers;
    }

}
