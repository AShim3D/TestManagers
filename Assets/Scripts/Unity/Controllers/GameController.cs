using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private IWorld _world;

    public void Awake() {
        var contexts = new Contexts();
        var managers = new UnityManagers(contexts);
        var systems = new UnitySystems(contexts, managers);
        _world = new GameWorld(contexts, systems.GetSystems());
    }

    public void Start() {
        _world.Initialize();
    }

    public void Update() {
        _world.Execute();
    }

    public void OnDestroy() {
        _world.Destroy();
    }

}
