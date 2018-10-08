using System.Collections;
using System.Collections.Generic;
using RoboRyanTron.Unite2017.Variables;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    public FloatVariable point;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Random.value > 0.25)
        {
            point.ApplyChange(1);
        }
        else point.ApplyChange(2);
    }
}
