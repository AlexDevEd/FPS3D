using System.Collections;
using System.Collections.Generic;
using TPS3D;
using UnityEngine;

public class FireBall : BaseObjectScene
{
    public float speed = 20f;
    public float damage = 20;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.ApplyDamage(damage);
        }

        Destroy(this.gameObject);
    }
}

