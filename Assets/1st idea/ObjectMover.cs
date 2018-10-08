using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{

    public void Move(Vector3 translateAmount)
    {

        transform.Translate(translateAmount);

    }

}
