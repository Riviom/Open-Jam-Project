using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void RestartTheScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
