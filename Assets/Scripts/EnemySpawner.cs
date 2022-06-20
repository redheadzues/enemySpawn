using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{    
    [SerializeField] private float _spawnTime;
    [SerializeField] private Enemy _enemy;

    private Transform[] _spawnPoints;
    private float _runningTime;

    
    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();
        StartCoroutine(SpawnEnemy());
    }



    private IEnumerator SpawnEnemy()
    {
        while(_spawnTime > 0)
        {
            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

            Instantiate(_enemy, spawnPoint.position, Quaternion.identity);

            var waitingTime = new WaitForSeconds(_spawnTime);

            yield return waitingTime;
        }
    }
}
