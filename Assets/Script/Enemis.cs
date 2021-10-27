using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemis : MonoBehaviour
{
    private Transform enemyTransform { get; set; } = null;

    private void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }

  
    void Update()
    {
        enemyTransform.position += Vector3.forward * Time.deltaTime * 3;
    }
}
