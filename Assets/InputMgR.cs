using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMgR : MonoBehaviour
{

    public float speed;

    // this code is so bad...

    public float UpperLimit;
    public float LowerLimit;

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > LowerLimit)
        {
            transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < UpperLimit)
        {
            transform.Translate(0, 1 * speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        // throw new NotImplementedException();
    }
}
