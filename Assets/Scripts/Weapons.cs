using UnityEngine;
using System.Collections;
using Assets.Scripts.Helper;

namespace TPS.Objects
{
    public abstract class Weapons : BaseObjectScene
    {
        [SerializeField] protected Transform _gun;
        [SerializeField] protected float _force = 500f;
        [SerializeField] protected float _rechargeTime = 0.2f;

        protected Timer _recharge = new Timer();
        protected bool _fire = true;

        public abstract void Fire(Ammunition ammunition);

        protected virtual void Update()
        {
            _recharge.Update();
            if (_recharge.IsEvent())
                _fire = true;
        }
    }
}
