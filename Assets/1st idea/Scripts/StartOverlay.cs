using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartOverlay : MonoBehaviour
{

    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] Text endScore;
    [SerializeField] Text highscoreText;
    [SerializeField] Text attemptsText;


    int highscore;
    int endscore;
    int attempts;

    public string ANDROID_RATE_URL;
    public string IPHONE_RATE_URL;
    AsyncOperation async;

    private void Awake(){
        Time.timeScale = 1;
    }

    private void Start()
    {
        PreloadScene();
        DisplayAttempts();
        DisplayHighscore();
        TapPlay();
        //DisplayGameOver();
        DisplayHighscore();
    }

    private void PreloadScene()
    {
        async = SceneManager.LoadSceneAsync("Main");
        async.allowSceneActivation = false;
    }

    public void FirstPlay()
    {
        async.allowSceneActivation = true;
        //SceneManager.LoadScene("Main");
        ResetBonus();
        endPanel.gameObject.SetActive(false);
    }

    public void TapPlay()
    {
        playButton.onClick.AddListener(FirstPlay);
    }

    void EndGameWithHighscore()
    {
        endScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        highscoreText.text = PlayerPrefs.GetInt("highscore").ToString();

    }
    void EndGameWithoutHighscore()
    {
        endScore.text = PlayerPrefs.GetInt("endscore").ToString();
        highscoreText.text = PlayerPrefs.GetInt("highscore").ToString();
    }
    // lasa doar Displaygameover in meniu
    /*void DisplayGameOver()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        endscore = PlayerPrefs.GetInt("endscore");

        if (GameManagerScript.gameManager.death == 1)
        {
            endPanel.gameObject.SetActive(true);
            if (highscore < endscore)
            {
                PlayerPrefs.SetInt("highscore", endscore);
                highscore = endscore;
                EndGameWithHighscore();

            }
            else
            {
                EndGameWithoutHighscore();

            }

            GameManagerScript.gameManager.death = 0;
        }
    }*/

    void DisplayHighscore()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreText.text = highscore.ToString();
    }

    void DisplayAttempts()
    {
        attempts = PlayerPrefs.GetInt("attempts");
        attemptsText.text = attempts.ToString();
    }

    public void RateButtonPressed()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_RATE_URL);
        Debug.Log("dada se intampla");
#elif UNITY_IPHONE
        Application.OpenURL(IPHONE_RATE_URL);
#endif
    }

    void ResetBonus()
    {
        PlayerPrefs.SetInt("rewardGiven", 0);
    }
}
