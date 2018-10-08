using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MoveInDirection))]
public class DirectionRandomizer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int x = UnityEngine.Random.value.CompareTo(0.5f);
        while (x == 0) x = UnityEngine.Random.value.CompareTo(0.5f);
        Mover.SpeedX.ConstantValue = Mover.SpeedX.ConstantValue * x;


        float y = UnityEngine.Random.value < 0.5 ? Random.Range(StartMin, ExceptedRangeMin) : Random.Range(ExceptedRangeMax, StartMax);
        Mover.SpeedY.ConstantValue = Mover.SpeedY.ConstantValue * y;

    }

    public void RandomizeSpeed()
    {
        Mover.SpeedX.ConstantValue = Mover.SpeedX.ConstantValue * Random.Range(ActivationMin, ActivationMax);
        Mover.SpeedY.ConstantValue = Mover.SpeedY.ConstantValue * Random.Range(ActivationMin, ActivationMax);
    }


    MoveInDirection Mover;
    public float StartMin, ExceptedRangeMin, ExceptedRangeMax, StartMax;
    public float ActivationMin = 0.92f;
    public float ActivationMax = 1.98f;

    private void Awake()
    {
        Mover = GetComponent<MoveInDirection>();
    }


}
