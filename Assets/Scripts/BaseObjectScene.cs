using UnityEngine;
using System.Collections;

namespace TPS3D
{ 
    public abstract class BaseObjectScene : MonoBehaviour
    {
        #region ObjectFields
        protected GameObject _instanceObject;
        protected Transform _myTransform;
        protected Rigidbody _rigidbody;
        protected Material _material;
        protected Vector3 _position;
        protected Vector3 _scale;
        protected Quaternion _rotation;
        protected Color _color;
        protected int _layer;
        protected string _name;
        protected bool _isVisible;
        #endregion

        #region ObjectProperties
        public GameObject InstanceObject
        {
            get { return _instanceObject; }
        }
        public Transform GetTransform
        {
            get { return _myTransform; }
        }
        public Rigidbody GetRigidbody
        {
            get { return _rigidbody; }
        }
        public Material GetMaterial
        {
            get { return _material; }
        }
        public Vector3 Position
        {
            get
            {
                if (_instanceObject != null)
                    _position = GetTransform.position;
                return _position;
            }
            set
            {
                _position = value;
                if (_instanceObject != null)
                    GetTransform.position = _position;
            }
        }
        public Vector3 Scale
        {
            get
            {
                if (_instanceObject != null)
                    _scale = GetTransform.localScale;
                return _scale;
            }
            set
            {
                _scale = value;
                if (_instanceObject != null)
                    GetTransform.localScale = _scale;
            }
        }
        public Quaternion Rotation
        {
            get
            {
                if (_instanceObject != null)
                    _rotation = GetTransform.rotation;
                return _rotation;
            }
            set
            {
                _rotation = value;
                if (_instanceObject != null)
                    GetTransform.rotation = _rotation;
            }
        }
        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                if (_material != null)
                    _material.color = _color;
                AskColor(GetTransform, _color);
            }
        }
        public int Layer
        {
            get { return _layer; }
            set
            {
                _layer = value;
                if (_instanceObject != null)
                    _instanceObject.layer = _layer;
                AskLayer(GetTransform, value);
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _instanceObject.name = _name;
            }
        }
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                if (_instanceObject.GetComponent<MeshRenderer>())
                    _instanceObject.GetComponent<MeshRenderer>().enabled = _isVisible;
                if (_instanceObject.GetComponent<SkinnedMeshRenderer>())
                    _instanceObject.GetComponent<SkinnedMeshRenderer>().enabled = _isVisible;
            }
        }
        #endregion

        private void AskLayer(Transform obj, int lvlLayer)
        {
            obj.gameObject.layer = lvlLayer;
            if(obj.childCount > 0)
            {
                foreach (Transform child in obj)
                    AskLayer(child, lvlLayer);
            }
        }

        private void AskColor(Transform obj, Color color)
        {
            obj.gameObject.GetComponent<Renderer>().material.color = color;
            if(obj.childCount > 0)
            {
                foreach (Transform child in obj)
                    AskColor(child, color);
            }
        }

        public void DisableRigidBody()
        {
            _rigidbody.isKinematic = true;
            _rigidbody.detectCollisions = false;
        }
        public void EnableRigidBody()
        {
            _rigidbody.isKinematic = false;
            _rigidbody.detectCollisions = true;
        }
        public void ConstraintsRigidBody(RigidbodyConstraints rigidBodyConstraints)
        {
            _rigidbody.constraints = RigidbodyConstraints.None;
        }
        protected virtual void Awake()
        {
            _instanceObject = gameObject;
            _name = _instanceObject.name;
            if (GetComponent<Renderer>())
                _material = GetComponent<Renderer>().material;

            _rigidbody = _instanceObject.GetComponent<Rigidbody>();
            _myTransform = _instanceObject.transform;
        }
    }

}

