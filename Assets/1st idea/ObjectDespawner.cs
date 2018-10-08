using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class ObjectDespawner : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PooledObject pooledObject = collision.gameObject.GetComponent<PooledObject>();
        if (pooledObject != null)
        {
            pooledObject.pool.ReturnObject(pooledObject.gameObject);
        }
    }


}
