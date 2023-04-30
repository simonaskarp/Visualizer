using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float radius = 5;
    public int prefabCount = 10;

    private void Start()
    {
        var step = 360f / prefabCount;
        for (var angle = 0f; angle < 360; angle += step)
        {
            var obj = Instantiate(prefab, transform);
            var x = Mathf.Cos(angle * Mathf.Deg2Rad);
            var y = Mathf.Sin(angle * Mathf.Deg2Rad);
            obj.transform.localPosition = new Vector3(x, y, 0) * radius;
        }
    }
}
