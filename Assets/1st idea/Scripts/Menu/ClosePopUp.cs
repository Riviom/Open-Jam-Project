using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUp : MonoBehaviour {

    [SerializeField] Transform popUp;

    public void closePopUp()
    {
        popUp.gameObject.SetActive(false);
    }
}
