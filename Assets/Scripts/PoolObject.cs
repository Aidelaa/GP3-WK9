using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    public static PoolObject SharedInstance;
    public List<GameObject> PoolObjects;
    public GameObject ObjectsToPool;
    public int AmountToPool;
    private void Awake()
    {
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Create the pool object
        PoolObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < AmountToPool; i++)
        {
            tmp = Instantiate(ObjectsToPool);
            tmp.SetActive(false);
            PoolObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < AmountToPool; i++)
        {
            if (!PoolObjects[i].activeInHierarchy)
            {
                return PoolObjects[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
