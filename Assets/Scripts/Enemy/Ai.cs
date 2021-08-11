using System.Collections;
using System.Collections.Generic;
using TPS3D;
using UnityEngine;

public class Ai : BaseObjectScene
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _obstacleRange = 5.0f;
    [SerializeField] private float _rayRadius = 0.75f;
    [SerializeField] private GameObject _fireballPrefab;

    private GameObject _fireball;
    private bool _alive;

    void Start()
    {
        _alive = true;
    }

    void Update()
    {

        if (_alive)
        {
            transform.Translate(0, 0, _speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, _rayRadius, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;

                if (hitObject.GetComponent<PlayerCharacter>()) 
                { 
                    if (_fireball == null) 
                    { 
                        _fireball = Instantiate(_fireballPrefab) as GameObject;
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < _obstacleRange) 
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }    
            }
        }
    }
    public void SetAlive(bool alive) => _alive = alive; 
}
