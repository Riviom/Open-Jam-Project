using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateAppPopUp : MonoBehaviour {


    [SerializeField] Transform popUp;

    public int attempts;

	void Start () {
        spawnPopUp();
	}



    void spawnPopUp()
    {
        if (PlayerPrefs.GetInt("rate1") == 0 && PlayerPrefs.GetInt("attempts") >= 20) {
        popUp.gameObject.SetActive(true);
        PlayerPrefs.SetInt("rate1", 1);
    }

        if (PlayerPrefs.GetInt("rate2") == 0 && PlayerPrefs.GetInt("attempts") >= 100)
        {
            popUp.gameObject.SetActive(true);
            PlayerPrefs.SetInt("rate2", 1);
        }
    }
}
