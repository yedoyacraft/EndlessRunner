using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadAboutScene()
    {
        SceneManager.LoadScene("About");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadAudioC()
    {
        SceneManager.LoadScene("AudioC");
    }
    public void ExitGame()
    {
        Debug.Log("Game Keluar"); 
        Application.Quit(); 

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#endif
    }
}
