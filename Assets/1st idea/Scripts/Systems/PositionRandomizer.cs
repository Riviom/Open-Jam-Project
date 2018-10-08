using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRandomizer : MonoBehaviour
{

    [SerializeField] float rangeOfSpawnLeft = -1.02f;
    [SerializeField] float rangeOfSpawnRight = 1.9f;

    private void OnEnable()
    {
        transform.position = new Vector3(Random.Range(rangeOfSpawnLeft, rangeOfSpawnRight), transform.position.y, transform.position.z);
    }



}
