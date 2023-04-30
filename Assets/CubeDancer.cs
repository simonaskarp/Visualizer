using UnityEngine;

public class CubeDancer : MonoBehaviour
{
    public float shrinkSpeed = 3;
    public float size = 5f;
    public float power = 2;
    float finalSize;

    public AudioVisualizer visualizer;

    public void Update()
    {
        var musicPower = 1 + Mathf.Pow(visualizer.average, power) * size;

        if (musicPower > finalSize)
        {
            finalSize = musicPower;
        }
        else
        {
            finalSize -= shrinkSpeed * Time.deltaTime;
        }

        //transform.localScale = Vector3.one * musicPower;
        transform.localScale = Vector3.one * finalSize;

        transform.Rotate(visualizer.average, visualizer.average, visualizer.average);
    }
}
