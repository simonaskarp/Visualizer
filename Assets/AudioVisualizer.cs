using UnityEngine;
using UnityEngine.Events;

public class AudioVisualizer : MonoBehaviour
{
    AudioSource audio;
    public float average;
    //public UnityEvent<float> onAnalyze;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float[] samples = new float[735];

        audio.clip.GetData(samples, audio.timeSamples);

        float sum = 0;
        foreach (var sample in samples)
        {
            sum += Mathf.Abs(sample);
        }

        average = sum / 735;
    }
}
