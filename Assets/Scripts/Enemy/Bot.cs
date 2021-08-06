using System;
using System.Collections.Generic;
using TPS3D.Interfaces;
using UnityEngine;

namespace TPS3D
{
    public class Bot : BaseObjectScene, ISetDamage
    {
        [SerializeField] private float _hp = 100; 
        private bool _isDead = false; 
        private float _step = 2f;
        void Update()
        {
            if (_isDead)
            {   
                    Destroy(InstanceObject.GetComponent<Collider>());
                    Destroy(InstanceObject, 5f);
            }
        }
        public void ApplyDamage(float damage)
        {
            if (_hp > 0)
            {
                _hp -= damage;
            }
            if (_hp <= 0)
            {
                _hp = 0;
                Color = Color.red;
                _isDead = true;
            }
        }
    }
}
