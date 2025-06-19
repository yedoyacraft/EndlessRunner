using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class SwitchSCene : MonoBehaviour
{
    public float delay = 3;
    public void SwitchTo(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void SwitchWithDelay(string name)
    {
        StartCoroutine(Delay(name, delay));
    }
    IEnumerator Delay(string name, float s)
    {
        yield return new WaitForSeconds(s);
        SwitchTo(name);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
