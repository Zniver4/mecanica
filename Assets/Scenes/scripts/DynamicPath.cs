using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPath : MonoBehaviour
{
    [Range(0.01f, 5)] public float r;
    [Range(-5, 5f)] public float w;
    [Range(0, 10f)] public float h;
    [Range(0, 10f)] public float t;
    public Transform platform;
    List<Vector3> points = new List<Vector3>();
    void Start()
    {
       GetComponent<LineRenderer>().widthMultiplier = 0.1f; 
    }

    
    void Update()
    {
        SamplePoints();
        platform.position = F(t);
    }
    void SamplePoints()
    {
       points.Clear();
        for(float t = 0f; t <10f; t += 0.025f)
        {
            Vector3 newPoint = F(t);
            points.Add(newPoint);
        }
        GetComponent<LineRenderer>().positionCount = points.Count;
        GetComponent<LineRenderer>().SetPositions(points.ToArray());
    }
    Vector3 F(float t)
    {
        float x = Mathf.Exp(r * t) * Mathf.Cos(w * t);
        float y = h * t;
        float z = Mathf.Exp(r * t) * Mathf.Sin(w * t);
        return new Vector3(x, y, z);

    }
}
