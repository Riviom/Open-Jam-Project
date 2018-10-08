using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;
[RequireComponent(typeof(ObjectMover))]
public class MoveInDirection : MonoBehaviour
{

    public FloatReference SpeedX, SpeedY;

    Vector3 velocity;

    ObjectMover movedObject;


    void Awake()
    {
        movedObject = GetComponent<ObjectMover>();
    }

    void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        velocity.x = SpeedX.Value;
        velocity.y = SpeedY.Value;
        movedObject.Move(velocity * Time.deltaTime);
    }
}
