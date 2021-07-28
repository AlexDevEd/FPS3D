using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPS3D
{
    public class ShotGun : Weapons
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
                    BulletShotGun tempBullet = Instantiate(ammunition, _bulletSpawn.position, _bulletSpawn.rotation) as BulletShotGun;
                    if (tempBullet)
                    {
                        tempBullet.GetRigidbody.AddForce(_bulletSpawn.forward * _force);
                        tempBullet.Name = "BulletShotGun";
                        _fire = false;
                        _recharge.Start(_rechargeTime);
                    }
                }
            }
        }
    }
}
