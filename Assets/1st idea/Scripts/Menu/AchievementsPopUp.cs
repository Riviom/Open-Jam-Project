using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsPopUp : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] float fadeIn = 1f, fadeOut = 1f, timeAppear = 1f;

    int A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, H1, H2, H3, H4, H5, H6, H7, H8, H9, H10;
    public int At1, At2, At3, At4, At5, At6, At7, At8, At9, At10, Hi1, Hi2, Hi3, Hi4, Hi5, Hi6, Hi7, Hi8, Hi9, Hi10;

	void Start () {
        achievement1();
        achievement2();
        achievement3();
        achievement4();
        achievement5();
        achievement6();
        achievement7();
        achievement8();
        achievement9();
        achievement10();
        highscore1();
        highscore2();
        highscore3();
        highscore4();
        highscore5();
        highscore6();
        highscore7();
        highscore8();
        highscore9();
        highscore10();
	}
	
    void achievement1(){
        if(PlayerPrefs.GetInt("A1") == 0 && PlayerPrefs.GetInt("attempts") >= At1){
            popUp();
            PlayerPrefs.SetInt("A1", 1);
        }
    }

    void achievement2()
    {
        if (PlayerPrefs.GetInt("A2") == 0 && PlayerPrefs.GetInt("attempts") >= At2)
        {
            popUp();
            PlayerPrefs.SetInt("A2", 1);
        }

    }

    void achievement3()
    {
        if (PlayerPrefs.GetInt("A3") == 0 && PlayerPrefs.GetInt("attempts") >= At3)
        {
            popUp();
            PlayerPrefs.SetInt("A3", 1);
        }
    }

    void achievement4()
    {
        if (PlayerPrefs.GetInt("A4") == 0 && PlayerPrefs.GetInt("attempts") >= At4)
        {
            popUp();
            PlayerPrefs.SetInt("A4", 1);
        }
    }

    void achievement5()
    {
        if (PlayerPrefs.GetInt("A5") == 0 && PlayerPrefs.GetInt("attempts") >= At5)
        {
            popUp();
            PlayerPrefs.SetInt("A5", 1);;
        }
    }

    void achievement6()
    {
        if (PlayerPrefs.GetInt("A6") == 0 && PlayerPrefs.GetInt("attempts") >= At6)
        {
            popUp();
            PlayerPrefs.SetInt("A6", 1);
        }
    }

    void achievement7()
    {
        if (PlayerPrefs.GetInt("A7") == 0&& PlayerPrefs.GetInt("attempts") >= At7)
        {
            popUp();
            PlayerPrefs.SetInt("A7", 1);
        }
    }

    void achievement8()
    {
        if (PlayerPrefs.GetInt("A8") == 0 && PlayerPrefs.GetInt("attempts") >= At8)
        {
            popUp();
            PlayerPrefs.SetInt("A8", 1);
        }
    }

    void achievement9()
    {
        if (PlayerPrefs.GetInt("A9") == 0 && PlayerPrefs.GetInt("attempts") >= At9)
        {
            popUp();
            PlayerPrefs.SetInt("A9", 1);
        }
    }

    void achievement10()
    {
        if (PlayerPrefs.GetInt("A10") == 0 && PlayerPrefs.GetInt("attempts") >= At10)
        {
            popUp();
            PlayerPrefs.SetInt("A10", 1);
        }
    }

    void highscore1()
    {
        if (PlayerPrefs.GetInt("H1")==0 && PlayerPrefs.GetInt("highscore") >= Hi1)
        {
            popUp();
            PlayerPrefs.SetInt("H1", 1);
        }
    }

    void highscore2()
    {
        if (PlayerPrefs.GetInt("H2") == 0 && PlayerPrefs.GetInt("highscore") >= Hi2)
        {
            popUp();
            PlayerPrefs.SetInt("H2", 1);
        }
    }

    void highscore3()
    {
        if (PlayerPrefs.GetInt("H3") == 0 && PlayerPrefs.GetInt("highscore") >= Hi3)
        {
            popUp();
            PlayerPrefs.SetInt("H3", 1);
        }
    }

    void highscore4()
    {
        if (PlayerPrefs.GetInt("H4") == 0 && PlayerPrefs.GetInt("highscore") >= Hi4)
        {
            popUp();
            PlayerPrefs.SetInt("H4", 1);
        }
    }

    void highscore5()
    {
        if (PlayerPrefs.GetInt("H5") == 0 && PlayerPrefs.GetInt("highscore") >= Hi5)
        {
            popUp();
            PlayerPrefs.SetInt("H5", 1);
        }
    }

    void highscore6()
    {
        if (PlayerPrefs.GetInt("H6") == 0 && PlayerPrefs.GetInt("highscore") >= Hi6)
        {
            popUp();
            PlayerPrefs.SetInt("H6", 1);
        }
    }

    void highscore7()
    {
        if (PlayerPrefs.GetInt("H7") == 0 && PlayerPrefs.GetInt("highscore") >= Hi7)
        {
            popUp();
            PlayerPrefs.SetInt("H7", 1);
        }
    }

    void highscore8()
    {
        if (PlayerPrefs.GetInt("H8") == 0 && PlayerPrefs.GetInt("highscore") >= Hi8)
        {
            popUp();
            PlayerPrefs.SetInt("H8", 1);
        }
    }

    void highscore9()
    {
        if (PlayerPrefs.GetInt("H9") == 0 && PlayerPrefs.GetInt("highscore") >= Hi9)
        {
            popUp();
            PlayerPrefs.SetInt("H8", 1);
        }
    }

    void highscore10()
    {
        if (PlayerPrefs.GetInt("H10") == 0 && PlayerPrefs.GetInt("highscore") >= Hi10)
        {
            popUp();
            PlayerPrefs.SetInt("H10", 1);
        }
    }


    void popUp()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(fadeIn);
        image.CrossFadeAlpha(225, fadeIn, true);
        yield return new WaitForSeconds(timeAppear);
        image.CrossFadeAlpha(1, fadeOut, true);
        yield return new WaitForSeconds(fadeOut);
    }
}
