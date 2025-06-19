using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obscol : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //print($"collision boss {collision.gameObject.name}");

        if (collision.gameObject.name == "player")
        {
            //print($"nsbrsak boss {collision.gameObject.name}");
            collision.gameObject.GetComponentInChildren<Camera>().transform.parent = null;
            var vfx = Instantiate(collision.gameObject.GetComponent<PlayerBehaviour>().vfx);
            vfx.transform.position = collision.gameObject.transform.position;
            vfx.transform.localScale = collision.gameObject.transform.localScale;
            Destroy(collision.gameObject);
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