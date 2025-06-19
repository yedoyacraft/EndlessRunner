using UnityEngine;

public class MichrophoneInputLoudness : MonoBehaviour
{
    private AudioClip microphoneClip;
    private string microphoneName;
    private int sampleWindow = 128;
    public float loudness = 0;
    public float strength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    if (Microphone.devices.Length > 0)
    //    {
    //        microphoneName = Microphone.devices[0];
    //        microphoneClip = Microphone.Start(microphoneName, true, 10, AudioSettings.outputSampleRate);
    //        Debug.Log("Using Microphone: " + microphoneName);
    //    }
    //    else
    //    {
    //        Debug.LogError("No microphone detected!");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if (microphoneClip != null)
        {
            loudness = GetLoudnessFromMicrophone() * strength;
        }
    }

    float GetLoudnessFromMicrophone()
    {
        float[] waveData = new float[sampleWindow];
        int position = Microphone.GetPosition(microphoneName) - sampleWindow + 1;
        if (position < 0) return 0;

        microphoneClip.GetData(waveData, position);

        float loud = 0;
        for (int i = 0; i < sampleWindow; i++)
        {
            loud += Mathf.Abs(waveData[i]);
        }

        return loud / sampleWindow;
    }
}
