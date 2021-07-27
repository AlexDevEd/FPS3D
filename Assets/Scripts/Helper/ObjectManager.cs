using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  TPS3D.Helper
{ 
    public class ObjectManager : MonoBehaviour
    {
        [SerializeField] private Ammunition[] _ammunitionsList = new Ammunition[5];
        [SerializeField] private Weapons[] _weaponsList = new Weapons[5];

        public Weapons[] GetWeaponsList
        {
            get { return _weaponsList; }
        }

        public Ammunition[] GetAmmunitionList
        {
            get { return _ammunitionsList; }
        }


    }
}
