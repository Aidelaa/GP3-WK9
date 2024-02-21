using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = PoolObject.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = bulletSpawnPoint.transform.position;
                bullet.transform.rotation = bulletSpawnPoint.transform.rotation;
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * speed;
                bullet.SetActive(true);
            }
        }
    }
}
