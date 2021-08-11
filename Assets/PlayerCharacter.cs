using System.Collections;
using System.Collections.Generic;
using TPS3D;
using TPS3D.Interfaces;
using UnityEngine;

public class PlayerCharacter : BaseObjectScene, ISetDamage
{
   [SerializeField] private float _health = 100f;

    public void ApplyDamage(float damage)
    {
        _health -= damage;
        Debug.Log("Health: " + _health);
    }
}
