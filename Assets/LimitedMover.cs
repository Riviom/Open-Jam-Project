using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedMover : ObjectMover
{
    public float UpperLimit, LowerLimit;

    public new void Move(Vector3 vector)
    {
        if ((vector.y + transform.position.y > LowerLimit) && (vector.y + transform.position.y <= UpperLimit)) transform.Translate(vector);

    }
}
