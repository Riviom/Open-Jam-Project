using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMgL : MonoBehaviour
{

    //badly written; not respecticting single responsability

    public float speed;

    public float UpperLimit;
    public float LowerLimit;

    void Update()
    {
        if (Input.GetKey(KeyCode.S) && transform.position.y > LowerLimit)
        {
            transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.W) && transform.position.y < UpperLimit)
        {
            transform.Translate(0, 1 * speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        //   throw new NotImplementedException();
    }
}
