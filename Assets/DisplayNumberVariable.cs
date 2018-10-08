using System.Collections;
using System.Collections.Generic;
using RoboRyanTron.Unite2017.Variables;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNumberVariable : MonoBehaviour
{

    public FloatVariable textNumber;
    Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = textNumber.Value.ToString();
    }
}
