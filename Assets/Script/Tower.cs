using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{


    public GameObject _upgrade = null;
    public GameObject upgrade { get { return _upgrade; } }

    private List<Enemis> enemis { get; set; } = null;

    public float _fireRate = 0.1f;

    private float fireRate { get { return _fireRate; } set { _fireRate = value; } }

    private float currentFireRate { get; set;} = 0;
    

    private bool canShoot { get; set; } = true;





    private void Start()
    {
        enemis = new List<Enemis>();
    }

    
    private void Update()
    {
        
        if (!canShoot)
            {
            currentFireRate += Time.deltaTime;
            if (currentFireRate >= fireRate)
                {
                canShoot = true;
                currentFireRate = 0;
                }
            return;
            }
        if (enemis != null && enemis.Count > 0)
            {
                Debug.Log("Shoot");
                canShoot = false;

            }
        
    }
    public void Upgrade()
    {
        if (upgrade == null)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemis enemy = other.GetComponent<Enemis>();
        if (enemy != null)
        {
            enemis.Add(enemy);
        }

     
    }
    private void OnTriggerExit(Collider other)
    {
        Enemis enemy = other.GetComponent<Enemis>();
        if (enemy != null)
        {
            enemis.Remove(enemy);
        }
    }
}
