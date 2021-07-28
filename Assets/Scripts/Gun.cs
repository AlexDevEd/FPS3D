using System.Collections;
using UnityEngine;

namespace TPS3D
{
    public class Gun : Weapons
    {
        void Start()
        {
            IsVisible = false;
        }
        public override void Fire(Ammunition ammunition)
        {
            if (_fire)
            {
                if (ammunition)
                {
                     Bullet tempBullet = Instantiate(ammunition, _gun.position, _gun.rotation) as Bullet;
                    if (tempBullet)
                    {
                        tempBullet.GetRigidbody.AddForce(_gun.forward * _force);
                        tempBullet.Name = "Bullet";
                        _fire = false;
                        _recharge.Start(_rechargeTime);
                    }
                }
            }
        }
    }
}
 