using UnityEngine;
using UnityEngine.Rendering;

public class AudioVisualizer : MonoBehaviour
{
    AudioSource audio;
    public float size = 5f;
    public float power = 2;
    float finalSize;
    public float shrinkSpeed = 3;

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

        var musicPower = (1 + Mathf.Pow(average, power) * size);

        if(musicPower > finalSize)
        {
            finalSize = musicPower;
        }
        else
        {
            finalSize -= shrinkSpeed * Time.deltaTime;
        }

        //transform.localScale = Vector3.one * musicPower;
        transform.localScale = Vector3.one * finalSize;

        transform.Rotate(average, average, average);
    }
}
