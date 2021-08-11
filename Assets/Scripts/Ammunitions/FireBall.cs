using System.Collections;
using System.Collections.Generic;
using TPS3D;
using UnityEngine;

public class FireBall : BaseObjectScene
{
    public float speed = 2.0f;
    public int damage = 1;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        { 
            Debug.Log("Player hit"); 
        }

        Destroy(this.gameObject);
    }
}

