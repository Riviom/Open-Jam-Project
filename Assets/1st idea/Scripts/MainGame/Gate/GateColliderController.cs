using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateColliderController : MonoBehaviour
{
    //da
    Collider2D col;
    private void Awake()
    {
        col = GetComponent<Collider2D>();

    }
    [SerializeField] float offsetIfGate = 0.6f;
    [SerializeField] float offsetNoGate = 0.1f;
    Vector2 offset = new Vector2(0, 0);
    public Transform GateInFront { private get; set; }

    private void Update()
    {
        offset.y = SetColliderPozition();
        col.offset = offset;
    }

    private float SetColliderPozition()
    {
        if (GateInFront != null)
        {
            if (GateInFront.gameObject.activeSelf)
                return offsetIfGate;
        }
        return offsetNoGate;
    }
}
