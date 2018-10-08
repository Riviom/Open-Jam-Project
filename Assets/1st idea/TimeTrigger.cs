using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections;

public class TimeTrigger : MonoBehaviour
{
    public UnityEvent OnTimeTrigger;
    public float activationTime;
    private float startTime;
    public bool looping;

    private void OnEnable()
    {
        ResetTimer();
    }

    public void ResetTimer()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if ((Time.time > activationTime + startTime) && (OnTimeTrigger != null))
        {
            OnTimeTrigger.Invoke();
            if (looping == false)
                this.enabled = false;
            ResetTimer();
        }
    }

}

