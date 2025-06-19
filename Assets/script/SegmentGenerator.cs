using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;


    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }

    }

   IEnumerator SegmentGen()
{
    
    segmentNum = Random.Range(0, 3);

    // Perlin Noise - hanya sebagai tambahan kecil tanpa efek besar
    float perlinOffset = Mathf.PerlinNoise(Time.time, 0.0f); // menghasilkan nilai antara 0.0 dan 1.0
    float xOffset = (perlinOffset - 0.5f) * 2f; // ubah jadi rentang -1.0 sampai 1.0

    // Spawn prefab dengan sedikit variasi posisi x
    GameObject prefab = Instantiate(
        segment[segmentNum], 
        new Vector3(xOffset, 0, zPos), 
        Quaternion.identity
    ) as GameObject;

    // Rotasi prefab tetap
    prefab.transform.localEulerAngles = new Vector3(0, 90, 0);

    // Geser posisi z untuk segment berikutnya
    zPos += 50;

    // Delay sebelum generate berikutnya
    yield return new WaitForSeconds(3);
    creatingSegment = false;
}


}
