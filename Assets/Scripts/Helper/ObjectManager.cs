using System.Collections;
using System.Collections.Generic;
using TPS.Objects;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private Ammunition[] _ammunitionsList = new Ammunition[5];
    [SerializeField] private Weapons[] _weaponsList = new Weapons[5];

    public Weapons[] GetBullet 
    { 
        get { return _weaponsList; }
    }

    public Ammunition[] GetAmmunitionList
    {
        get { return _ammunitionsList; }
    }
}
