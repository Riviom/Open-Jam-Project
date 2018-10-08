using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ExplosionOnDistroy))]
public class BallExplode : MonoBehaviour
{
    ExplosionOnDistroy explosion;
    private void Awake()
    {
        explosion = GetComponent<ExplosionOnDistroy>();
    }
    private void OnEnable()
    {
        WinLoseManager.OnLose += WinLoseManager_OnLose;
    }

    private void OnDisable()
    {
        WinLoseManager.OnLose -= WinLoseManager_OnLose;
    }

    private void WinLoseManager_OnLose(Transform _transform)
    {
        explosion.Explode(_transform);
    }
}
