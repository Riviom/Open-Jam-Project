using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField] float gateSpeed = 10;
    float maxDistanceLeft = -1.5f;
    float maxDistanceRight = 1.86f;
    //  [SerializeField] float gameSpeed = 1f;

    //void Update()
    //{
    // transform.Translate(0, 1 * Time.deltaTime * gameSpeed, 0);

    // Controls();
    // }
    //if (transform.position.y >= CameraController.control.transform.position.y + 6)
    //{

    //    GateSpawner.spawner.AddToQueue(gameObject);
    //}
    //void Controls()
    //{

    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        if (transform.position.x >= maxDistanceLeft)
    //        {
    //            transform.Translate(-1 * Time.deltaTime * gateSpeed, 0, 0);
    //        }
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        if (transform.position.x <= maxDistanceRight)
    //        {
    //            transform.Translate(1 * Time.deltaTime * gateSpeed, 0, 0);
    //        }
    //    }
    //}


    //private void OnMouseDrag()
    //{

    //    Vector3 mousePosition = new Vector3(Input.mousePosition.x, transform.localPosition.y, transform.position.z);
    //    Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    //    if (objPosition.x >= maxDistanceLeft && objPosition.x <= maxDistanceRight)
    //    {
    //        transform.position = new Vector3(objPosition.x, transform.localPosition.y, transform.position.z);
    //    }
    //}
    private void OnMouseDrag()
    {
        if (Input.touchCount > 0)
        {

            TouchMoved();

        }
    }
    private void TouchMoved()
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Moved)
        {
            float amountTouchMoved = touch.deltaPosition.x / touch.deltaTime;//Input.GetTouch(0).deltaPosition.x;
            MoveGate(amountTouchMoved);
        }
    }

    private void MoveGate(float amountTouchMoved)
    {


        float amountGateMoved = amountTouchMoved / gateSpeed;

        if (amountTouchMoved < 0 && transform.position.x >= maxDistanceLeft)
        {
            transform.Translate(amountGateMoved * Time.deltaTime, 0, 0);
        }
        if (amountTouchMoved > 0 && transform.position.x <= maxDistanceRight)
        {
            transform.Translate(amountGateMoved * Time.deltaTime, 0, 0);
        }
    }
}