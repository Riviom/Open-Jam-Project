using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterEvent : MonoBehaviour
{
    public UnityEvent OnTriggerEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnTriggerEvent.Invoke();
    }
}
