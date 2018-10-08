using System.Collections;
using RoboRyanTron.Unite2017.Variables;
using UnityEngine;

public class Despawner : MonoBehaviour
{

    public void Despawn()
    {
        PooledObject pooledObject = GetComponent<PooledObject>();
        if (pooledObject != null)
            pooledObject.pool.ReturnObject(gameObject);
    }




    //PooledObject pooledObject;
    //[SerializeField] FloatReference wait;

    //void Start()
    //{
    //    pooledObject = GetComponent<PooledObject>();
    //    if (pooledObject != null)
    //    {
    //        StartCoroutine(Despawn());
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Wrong object returned to pool.");
    //        Destroy(gameObject);
    //    }

    //}

    //IEnumerator Despawn()
    //{
    //    yield return new WaitForSeconds(wait.Value);
    //    pooledObject.pool.ReturnObject(gameObject);
    //}
}
