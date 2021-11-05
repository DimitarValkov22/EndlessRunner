using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSpawner : MonoBehaviour
{
    [SerializeField] Knight _knightPrefabToSpawn;
    [SerializeField] float _spawnRate = 5f;

    double _nextTime;


    void Update()
    {
        if(Time.time >= _nextTime)
        {
            var spawnedKnight = Instantiate(_knightPrefabToSpawn, transform.position, transform.rotation);
            FindObjectOfType<TEST>().Knights.Add(spawnedKnight);

            _nextTime = Time.time + _spawnRate;
        }
    }
}
