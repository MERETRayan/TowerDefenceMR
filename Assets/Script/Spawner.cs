using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float _spawnTime = 0.1f;

    private float spawnTime { get { return _spawnTime; } }

    public GameObject _enemyPrefab = null;
    private GameObject enemyPrefab {  get { return _enemyPrefab; } }





    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnTime);
    }

    private void Spawn()
    {
        Vector3 randomPos = transform.position;
        randomPos.x += Random.Range(-3.0f, 3.0f);
        Instantiate(enemyPrefab, randomPos, transform.rotation);
    }
    
    void Update()
    {
      
    }
}
