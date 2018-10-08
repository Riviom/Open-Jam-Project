using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;
[RequireComponent(typeof(PoolingSystem))]
public class ObjectSpawner : MonoBehaviour
{

    PoolingSystem poolingSystem;


    void Awake()
    {
        poolingSystem = GetComponent<PoolingSystem>();
    }

    public void Spawn()
    {
        poolingSystem.GetObject();
    }
}
