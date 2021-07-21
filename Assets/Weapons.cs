using UnityEngine;
using System.Collections;

namespace TPS.Objects
{
    public abstract class Weapons : BaseObjectScene
    {
        [SerializeField] private Transform _gun;
        [SerializeField] private float _force = 500f;
        [SerializeField] private float _rechargeTime = 0.2f;

        protected bool _fire = true;

        public abstract void Fire();
    }
}
