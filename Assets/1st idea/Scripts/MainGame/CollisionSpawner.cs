using System.Collections;
using UnityEngine;
[RequireComponent(typeof(PoolingSystem))]
public class CollisionSpawner : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float timeUntilDespawn = 1f;
    //[SerializeField] Transform objectHit;
    [SerializeField] bool aleaCiudate;
    //change this into transforms later
    GameObject spawnedObject;

    PoolingSystem pool;
    void Awake()
    {
        pool = GetComponent<PoolingSystem>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var contact = collision.contacts[0];

        float x = contact.normal.x;
        float y = contact.normal.y;
        float t = Mathf.Asin((x / Mathf.Sqrt(x * x + y * y)));
        float z = t * (180 / Mathf.PI);

        //   Instantiate(objectHit, contact.point, Quaternion.Euler(z + 90, 90, 0));
        //- z +90
        spawnedObject = pool.GetObject();
        if (aleaCiudate)
        {
            spawnedObject.transform.rotation = Quaternion.Euler(0, 0, z + 90);
        }
        else
        {

            spawnedObject.transform.rotation = Quaternion.Euler(-z - 90, 90, 0);
        }
        spawnedObject.transform.position = contact.point;
        StartCoroutine(DeactivateObject());
    }


    IEnumerator DeactivateObject()
    {
        yield return new WaitForSeconds(timeUntilDespawn);
        pool.ReturnObject(spawnedObject);
    }

}
