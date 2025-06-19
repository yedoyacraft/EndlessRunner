using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    [SerializeField] AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        //print("membesar");
        coinFX.Play();
        this.gameObject.SetActive(false);
        Transform parent = other.gameObject.transform.parent;
        ////print(parent.gameObject.name);
        //parent.localScale = parent.transform.localScale * 1.1f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        coinFX.Play();
        //Destroy(this.gameObject);
    }

}
