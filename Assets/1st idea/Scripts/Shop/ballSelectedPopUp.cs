using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballSelectedPopUp : MonoBehaviour {


    [SerializeField] Image image;
    [SerializeField] float fadeIn = 1f, fadeOut = 1f, timeAppear = 1f;

	// Use this for initialization
	public void buttonPressed () {
        StartCoroutine(Load());
	}
	
    IEnumerator Load()
    {
        
        image.CrossFadeAlpha(225, fadeIn, true);
        yield return new WaitForSeconds(fadeIn);
        yield return new WaitForSeconds(timeAppear);
        image.CrossFadeAlpha(1, fadeOut, true);
        yield return new WaitForSeconds(fadeOut);
    }
}
