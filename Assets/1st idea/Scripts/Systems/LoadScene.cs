using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    [SerializeField] string SceneName;
    public void LoadTheScene()
    {
        SceneManager.LoadScene(SceneName);
        //Time.timeScale = 1;
    }

}
