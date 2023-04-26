using UnityEngine;
using UnityEngine.Rendering;

public class AudioVisualizer : MonoBehaviour
{
    AudioSource audio;
    public float size = 5f;
    public float power = 2;

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
        float average = sum / 735;

        transform.localScale = Vector3.one * (1 + Mathf.Pow(average, power) * size);

        transform.Rotate(0, average, 0);
    }
}
