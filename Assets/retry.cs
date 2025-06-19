using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Start()
    {
        string sc = PlayerPrefs.GetFloat("score").ToString("F2");
        text.SetText(sc);
    }
    public void SwitchTo(string name)
    {
        SceneManager.LoadScene(name);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}