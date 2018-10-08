using UnityEngine;
using UnityEngine.SceneManagement;
using RoboRyanTron.Unite2017.Variables;
using System.Collections;

public class GameManagerScript : MonoBehaviour
{
    public float endGameScore = 100;
    public FloatReference scoreLeft, scoreRight;
    public GameObject UI;

    float score;
    private void Start()
    {
        StartCoroutine(WaitForStart());
    }
    private void Update()
    {

        if (scoreLeft >= endGameScore || scoreRight >= endGameScore)
        {
            EndGame();
        }
    }
    IEnumerator WaitForStart()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(3f);
        Time.timeScale = 1;
    }
    void EndGame()
    {
        Time.timeScale = 0;
        UI.SetActive(true);
    }

}

