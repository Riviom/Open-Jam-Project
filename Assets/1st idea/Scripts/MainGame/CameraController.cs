using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController control;
    //  float gameSpeed = 2f;
    public Transform player;
    Vector3 cameraPosition = new Vector3(0, 0, 0);
    [SerializeField] float offset = -3.5f;
    private float lastCameraPostion;

    private void Awake()
    {

        control = this;

    }

    private void LateUpdate()
    {

        cameraPosition.y = player.position.y + offset;

        transform.position = cameraPosition;

    }

}
