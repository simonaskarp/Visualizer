using UnityEngine;

public class SphereDancer : MonoBehaviour
{
    AudioVisualizer visualizer;
    public float power = 2;


    private void Start()
    {
        visualizer = GetComponent<AudioVisualizer>();
    }

    void Update()
    {
        transform.localPosition = -transform.forward * visualizer.average * 10;
    }
}
