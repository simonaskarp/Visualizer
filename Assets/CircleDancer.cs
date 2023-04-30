using System.Drawing;
using UnityEngine;

public class CircleDancer : MonoBehaviour
{
    public AudioVisualizer visualizer;
    public float power = 2;
    float rotatePower;

    void Update()
    {
        if (visualizer.average >= 0.07f)
        {
            rotatePower = 1 + Mathf.Pow(visualizer.average, power);
        }
        else
        {
            rotatePower = 0;
        }
        
        transform.Rotate(0, 0, rotatePower);
    }
}
