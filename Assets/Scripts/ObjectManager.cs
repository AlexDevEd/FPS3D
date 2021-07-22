using System.Collections;
using System.Collections.Generic;
using TPS.Objects;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private Ammunition[] _ammunitionsList = new Ammunition[5];
    [SerializeField] private Weapons[] _weaponsList = new Weapons[5];

    public Bullet GetBullet
    {
        get { return _bullet}
    }

}
