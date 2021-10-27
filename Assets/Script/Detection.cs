using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    private Tower towerParent { get; set; } = null;
    private void Start()
    {
        towerParent = GetComponentInParent<Tower>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemis enemy = other.GetComponent<Enemis>();
        if (enemy != null)
        {
            towerParent.AddEnemy(enemy);
        }


    }
    private void OnTriggerExit(Collider other)
    {
        Enemis enemy = other.GetComponent<Enemis>();
        if (enemy != null)
        {
            towerParent.RemoveEnemy(enemy);
        }
    }// Start is called before the first frame update
}