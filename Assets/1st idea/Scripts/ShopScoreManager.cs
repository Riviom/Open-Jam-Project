using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScoreManager : MonoBehaviour
{

    [SerializeField] Text highscore;
    [SerializeField] Text nrAttempts;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
        nrAttempts.text = PlayerPrefs.GetInt("attempts").ToString();
    }
}


