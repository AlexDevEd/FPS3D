using System.Collections;
using System.Collections.Generic;
using TPS3D.Interfaces;
using UnityEngine;

namespace TPS3D
{
    public class Bullet : Ammunition
    {
        [SerializeField] private float _timeToDestruct = 10f;
        [SerializeField] private float _damage = 20f;
        [SerializeField] private float _mass = 0.01f;

        private float _currentDamage;

        protected override void Awake()
        {
            base.Awake();
            Destroy(InstanceObject, _timeToDestruct);
            _currentDamage = _damage;
            GetRigidbody.mass = _mass;
        }
        void Start()
        {

        }

        void Update()
        {

        }
        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log(collision.gameObject.name);
            if (collision.collider.tag == "Bullet") return;

            SetDamage(collision.gameObject.GetComponent<ISetDamage>());
            
            Destroy(InstanceObject);
        }

        private void SetDamage(ISetDamage obj)
        {
            if (obj != null)
                obj.ApplyDamage(_currentDamage);
        }
    }
}
