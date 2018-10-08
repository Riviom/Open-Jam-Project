using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using RoboRyanTron.Unite2017.Variables;

public class CollisionActivation : MonoBehaviour
{
    DirectionRandomizer sr;
    MoveInDirection mover;

    void Awake()
    {
        sr = GetComponent<DirectionRandomizer>();
        mover = GetComponent<MoveInDirection>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sr.RandomizeSpeed();
        ChangeDirection(collision);
    }

    private void ChangeDirection(Collision2D col)
    {
        if (!col.collider.isTrigger)
        {
            PersonalValue pv;
            pv = col.gameObject.GetComponent<PersonalValue>();

            if (pv != null)
            {
                mover.SpeedX.ConstantValue = -mover.SpeedX.ConstantValue;
            }
            else mover.SpeedY.ConstantValue = -mover.SpeedY.ConstantValue;
        }
    }
}
