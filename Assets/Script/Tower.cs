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

    private float currentFireRate { get; set; } = 0;


    private bool canShoot { get; set; } = true;

    public int _value = 10;
    public int value {  get { return _value; } }





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
            Destroy(enemis[0].gameObject);
            enemis.RemoveAt(0);
            GameManager.instance.addGold(1);

        }

    }
    public void Upgrade()
    {
        if (upgrade == null)
        {
            return;
        }


        if (GameManager.instance.gold < value)
        {
            return;
        }



        Instantiate(upgrade, transform.position, transform.rotation);
        GameManager.instance.addGold(-10);
        Destroy(gameObject);
    }
    public void AddEnemy(Enemis enemy)
    {
        enemis.Add(enemy);
    }

    public void RemoveEnemy(Enemis enemy)
    {
        enemis.Remove(enemy);
    }

}
