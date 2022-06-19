using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnTime;

    private Transform[] _spawnPoints;
    private float _runningTime;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();   
    }

    private void Update()
    {
        _runningTime += Time.deltaTime;

        if( _runningTime > _spawnTime )
        {
            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

            Instantiate(_enemy,spawnPoint.position, Quaternion.identity);

            _runningTime = 0;       
        }
    }
}
