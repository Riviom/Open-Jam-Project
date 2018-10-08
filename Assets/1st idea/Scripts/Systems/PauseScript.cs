using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour
{
    public static PauseScript PauseManager;

    [SerializeField] Button PauseButton, UnpauseButton;
    [SerializeField] Text countdownText;
    [SerializeField] Transform pausePanel;

    int restartTime = 3;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        if (PauseManager == null)
        {
            PauseManager = this;
        }
        else
        {
            Destroy(this);

        }
    }



    public void Pause()
    {
        if (Time.timeScale >= 0.01)
        {
            PauseGame();
        }
        else UnPauseGame();
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
        UnpauseButton.gameObject.SetActive(true);

    }
    void UnPauseGame()
    {
        pausePanel.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(true);
        UnpauseButton.gameObject.SetActive(false);
        StartCoroutine(CountDown(restartTime));

    }
    public void PauseAfterReward()
    {
        Time.timeScale = 0;
        PauseButton.interactable = false;
        StartCoroutine(CountDown(restartTime));
        PauseButton.interactable = true;

    }


    IEnumerator CountDown(int _restartTime)
    {
        countdownText.gameObject.SetActive(true);
        for (int i = _restartTime; i > 0; i--)
        {
            DisplayCountdown(i);
            yield return new WaitForSecondsRealtime(1f);
        }
        DisplayCountdown(0);
        yield return new WaitForSecondsRealtime(0.15f);
        countdownText.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    void DisplayCountdown(int numberDisplayed)
    {
        countdownText.text = numberDisplayed.ToString();
    }



}
