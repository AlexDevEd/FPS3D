using System.Collections;
using UnityEngine;

namespace TPS.Objects
{
    public class Gun: Weapons
    {
        public override void Fire(Ammunition ammunition)
        {
            if (_fire)
            {
                if (ammunition)
                {
                    Bullet tempBullet = Instantiate(ammunition, _gun.position, _gun.rotation) as Bullet;
                }
            }
        }
    }
}
