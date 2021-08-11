using System.Collections;
using System.Collections.Generic;
using TPS3D.Controllers;
using UnityEngine;

public class SceneController : BaseController
{
    [SerializeField] private GameObject _enemyPrefab;
    private GameObject _enemy;

    void Update()
    {
        if (_enemy == null)
        {
            SpawnEnemies();
        }
    }
    private void SpawnEnemies()
    {
        _enemy = Instantiate(_enemyPrefab);
        _enemy.transform.position = new Vector3(Random.Range(2, 30), Random.Range(1, 1.5f), Random.Range(2, 30));
        float angle = Random.Range(0, 360);
        _enemy.transform.Rotate(0, angle, 0);
    }
}
