using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NextSceneName;
    public void LoadNextScene()
    {
        SceneManager.LoadScene(NextSceneName);
    }
}
