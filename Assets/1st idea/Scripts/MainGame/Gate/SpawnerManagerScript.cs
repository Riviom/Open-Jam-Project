using System.Collections;
using System;
using UnityEngine;

[RequireComponent(typeof(PoolingSystem), typeof(DifficultyController))]
public class SpawnerManagerScript : MonoBehaviour
{

    PoolingSystem poolingSystem;
    DifficultyController difficultyController;

    GameObject instance;


    float spawnOffset;
    void Awake()
    {
        poolingSystem = GetComponent<PoolingSystem>();
        difficultyController = GetComponent<DifficultyController>();
    }
    private void OnEnable()
    {
        WinLoseManager.OnPointScored += WinLoseManager_OnPointScored;
    }
    private void OnDisable()
    {
        WinLoseManager.OnPointScored -= WinLoseManager_OnPointScored;
    }
    private void Start()
    {
        instance = poolingSystem.GetObject();
        spawnOffset = difficultyController.GetSpawnOffset();
    }

    void Update()
    {
        if (instance.transform.position.y > (transform.position.y + spawnOffset))
        {
            instance = poolingSystem.GetObject();
            instance.transform.position = new Vector3(instance.transform.position.x, transform.position.y, transform.position.z);

            spawnOffset = difficultyController.GetSpawnOffset();
        }
    }
    public static event Action<Vector3> OnGateDistory = delegate { };

    void WinLoseManager_OnPointScored(Transform gate)
    {
        OnGateDistory(gate.position);
        poolingSystem.ReturnObject(gate.gameObject);
    }

    //void GraphicsSetActive(bool active, Transform gate)
    //{
    //    Transform graphics = gate.GetChild(0);
    //    graphics.gameObject.SetActive(active);
    //}

    //IEnumerator Return(Transform gate)
    //{
    //    yield return new WaitForSeconds(0.1f);
    //    poolingSystem.ReturnObject(gate.gameObject);
    //}

}
