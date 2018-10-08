using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{


    [SerializeField] float baseSpawnOffset = 100f;
    [SerializeField] float minimumVariance = 0.5f;
    [SerializeField] float maximumVariance = 1;




    public float GetSpawnOffset()
    {
        float currentSpawnOffset;


        currentSpawnOffset = baseSpawnOffset * UnityEngine.Random.Range(minimumVariance, maximumVariance) * DifficultyScaling();
        return currentSpawnOffset;
    }

    private float DifficultyScaling()
    {
        int score;
        //  score = GameManagerScript.gameManager.score;

        return 0.1f;
    }
    //float MinVariance(float _minimumVariance)
    //{
    //    float variance = 0.5f;

    //    return variance;
    //}
    //float SetMaxVariance(float _maximumVariance)
    //{
    //    float variance = 0.5f;

    //    return variance;
    //}

}
