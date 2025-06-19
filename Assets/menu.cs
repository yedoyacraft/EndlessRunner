using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public void start(string start)
    {
        SceneManager.LoadScene("Start");
    }

}