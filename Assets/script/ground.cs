using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ground : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            other.gameObject.GetComponentInChildren<Camera>().transform.parent = null;
            var vfx = Instantiate(other.gameObject.GetComponent<PlayerBehaviour>().vfx);
            vfx.transform.position = other.gameObject.transform.position;
            vfx.transform.localScale = other.gameObject.transform.localScale;
            Destroy(other.gameObject);
            PlayerPrefs.SetFloat("score", Time.timeSinceLevelLoad);
            print($"time {PlayerPrefs.GetFloat("score")}");
            StartCoroutine(loseDelay(3));
        }
    }
    IEnumerator loseDelay(float time)
    {

        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("lose");
    }
}
