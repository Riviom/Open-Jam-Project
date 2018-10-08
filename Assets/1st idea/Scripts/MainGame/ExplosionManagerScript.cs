using System.Collections;
using UnityEngine;
[RequireComponent(typeof(PoolingSystem))]
public class ExplosionManagerScript : MonoBehaviour
{

    PoolingSystem poolingSystem;
    GameObject gateExplosion;

    void Awake()
    {
        poolingSystem = GetComponent<PoolingSystem>();
    }

    private void OnEnable()
    {
        SpawnerManagerScript.OnGateDistory += SpawnerManagerScript_OnGateDistory;
    }

    private void OnDisable()
    {
        SpawnerManagerScript.OnGateDistory -= SpawnerManagerScript_OnGateDistory;
    }

    void SpawnerManagerScript_OnGateDistory(Vector3 position)
    {
        
        Explode(position);
        StartCoroutine(FinishExplosion());
    }


    private void Explode(Vector3 explodedObjectPosition)
    {
        gateExplosion = poolingSystem.GetObject();
        gateExplosion.transform.position = explodedObjectPosition;
    }

    IEnumerator FinishExplosion()
    {
        yield return new WaitForSeconds(1.5f);
        poolingSystem.ReturnObject(gateExplosion);
    }
}
