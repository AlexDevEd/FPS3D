using System.Collections;
using System.Collections.Generic;
using TPS.Controller;
using UnityEngine;

public class Main : MonoBehaviour
{
    private GameObject _controllersGameObject;
    private InputController _inputController;
    private FlashlightController _flashlightController;

    private static Main _instance;
    public static Main Instance { get; private set; }

    void Start()
    {
        Instance = this;
        _controllersGameObject = new GameObject { name = "Controllers" };
        _inputController = _controllersGameObject.AddComponent<InputController>();
        _flashlightController = _controllersGameObject.AddComponent<FlashlightController>();
    }

    public FlashlightController GetFlashlightController
    {
        get { return _flashlightController; }
    }

    public InputController GetInputController
    {
        get { return _inputController; }
    }

    void Update()
    {

    }
}
