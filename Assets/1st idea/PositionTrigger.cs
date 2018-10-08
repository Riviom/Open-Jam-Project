using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PositionTrigger : MonoBehaviour
{

    public UnityEvent OnPositionTrigger;

    public Vector3 TriggerPosition;

    void Update()
    {
        if (TriggerPosition == transform.position)
        {
        }
    }
}
