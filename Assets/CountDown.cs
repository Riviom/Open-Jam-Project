using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    private void Start()
    {
        StartCoroutine(TextCountdown());
    }
    IEnumerator TextCountdown()
    {
        for (int i = 3; i >= 0; i--)
        {
            text.text = i.ToString();
            yield return new WaitForSecondsRealtime(1f);
        }
        gameObject.SetActive(false);

    }
}
