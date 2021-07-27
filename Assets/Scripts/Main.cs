using System.Collections;
using System.Collections.Generic;
using TPS3D.Controllers;
using TPS3D.Helper;
using UnityEngine;

namespace TPS3D
{
    public class Main : MonoBehaviour
    {
        private GameObject _controllersGameObject;
        private InputController _inputController;
        private FlashlightController _flashlightController;
        private WeaponsController _weaponsController; 
        private ObjectManager _objectManager;

        public enum MouseButton 
        { 
            LeftButton,
            RightButton,
            CenterButton 
        }

        private static Main _instance;
        public static Main Instance { get; private set; }

        void Start()
        {
            Instance = this;
            _controllersGameObject = new GameObject { name = "Controllers" };
            _inputController = _controllersGameObject.AddComponent<InputController>();
            _flashlightController = _controllersGameObject.AddComponent<FlashlightController>();
            _weaponsController = _controllersGameObject.AddComponent<WeaponsController>();
            _objectManager = GetComponent<ObjectManager>();
        }

        public FlashlightController GetFlashlightController
        {
            get { return _flashlightController; }
        }

        public InputController GetInputController
        {
            get { return _inputController; }
        }

        public WeaponsController GetWeaponsController
        {
            get { return _weaponsController; }
        }
        public ObjectManager GetObjectManager
        {
            get { return _objectManager; }
        }
    }
}
