using Assets.Scripts;
using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPS.Objects
{
    public class Bullet : BaseObjectScene , ISetDamage
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
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Bullet") return;

            SetDamage(collision.gameObject.GetComponent<ISetDamage>());

            Destroy(InstanceObject);
        }

        private void SetDamage(ISetDamage obj)
        {
            if(obj != null)
                obj.ApplyDamage(_currentDamage);
        }

        public void ApplyDamage(float damage)
        {
            throw new System.NotImplementedException();
        }
    }
}
