using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu2 : MonoBehaviour
{
    public void start(string play)
    {
        Debug.Log("OK");
        //SceneManager.LoadScene("play");
    }

    public void Update()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        //void changeSchene(string sceneName);
        if (sceneName == "Menu")
        {
            if (Input.anyKey)
            {
                
                Debug.Log("masuk");
                SceneManager.LoadScene("play");
            }
        }
        else
        {
            Debug.Log("g masuk");
        }
    }
}
