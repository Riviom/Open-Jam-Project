using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Preloader : MonoBehaviour
{

    private CanvasGroup fadeGroup;
    private float loadTime;
    private float minimumLogoTime = 3.0f; //Minimum time of the preloader scene
    AsyncOperation asyncLoad;
    private void Start()
    {
        fadeGroup = FindObjectOfType<CanvasGroup>();
        //   asyncLoad = SceneManager.LoadSceneAsync("Menu");
        //   asyncLoad.allowSceneActivation = false;
        fadeGroup.alpha = 1;

        //Aici putem preloadui chestii din game plm
        //$$$$$$$

        if (Time.time < minimumLogoTime)
            loadTime = minimumLogoTime;
        else
            loadTime = Time.time;


        asyncLoad = SceneManager.LoadSceneAsync("Menu");
        asyncLoad.allowSceneActivation = false;
    }

    private void Update()
    {
        //asyncLoad.allowSceneActivation = true;
        if (Time.time < minimumLogoTime)
        {
            fadeGroup.alpha = 1 - Time.time;

        }
        if (Time.time > minimumLogoTime && loadTime != 0)
        {
            fadeGroup.alpha = Time.time - minimumLogoTime;

            if (fadeGroup.alpha >= 3)
            {
                asyncLoad.allowSceneActivation = true;
            }
        }

    }

    IEnumerator LoadYourAsyncScene()
    {


        while (asyncLoad.progress <= 85)
        {
            yield return null;
        }
        asyncLoad.allowSceneActivation = true;
    }
}




