using UnityEngine;
using System.Collections.Generic;

public class PoolingSystem : MonoBehaviour
{
    //change into transforms
    //search why use transforms instead of gameobjects


    //incercat dat reload la pooling systemul asta in alt unity project

    //schimba astea in eventuri in loc de injection cum e acum

    //vezi ca nu s foarte usor de schimbat in eventuri pt ca eventurile sunt statice
    // si deci nush cum refolosesti sistemu dupa

    //vezi talk urile alea cu scriptable objects in loc de referinte


    public GameObject prefab;
    Stack<GameObject> inactiveInstances = new Stack<GameObject>();

    /// <summary>
    /// Returns an object reference from the pool and spawns the object.
    /// </summary>
    /// <returns>The object.</returns>
    public GameObject GetObject()
    {
        GameObject spawnedGameObject;
        if (inactiveInstances.Count > 0)
        {
            spawnedGameObject = inactiveInstances.Pop();
        }
        else
        {
            spawnedGameObject = Instantiate(prefab);
            PooledObject pooledObject = spawnedGameObject.AddComponent<PooledObject>();
            pooledObject.pool = this;
        }
        spawnedGameObject.transform.SetParent(null);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.position = transform.position;

        return spawnedGameObject;
    }


    public void SpawnObject()
    {
        GameObject spawnedGameObject;
        if (inactiveInstances.Count > 0)
        {
            spawnedGameObject = inactiveInstances.Pop();
        }
        else
        {
            spawnedGameObject = Instantiate(prefab);
            PooledObject pooledObject = spawnedGameObject.AddComponent<PooledObject>();
            pooledObject.pool = this;
        }

        spawnedGameObject.transform.SetParent(null);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.position = transform.position;


    }
    /// <summary>
    /// Returns the object to the pool.
    /// </summary>
    /// <param name="toReturn">To return.</param>
    public void ReturnObject(GameObject toReturn)
    {
        PooledObject pooledObject = toReturn.GetComponent<PooledObject>();

        if (pooledObject != null && pooledObject.pool == this)
        {
            toReturn.transform.SetParent(transform);
            toReturn.SetActive(false);

            inactiveInstances.Push(toReturn);
        }


        else
        {
            Debug.LogWarning(toReturn.name + " was returned to a pool it wasn't spawned from! Destroying.");
            Destroy(toReturn);
        }
    }
}

public class PooledObject : MonoBehaviour
{
    public PoolingSystem pool;
}
