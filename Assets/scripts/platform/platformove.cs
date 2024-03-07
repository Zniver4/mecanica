using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class platformove : MonoBehaviour
{
    public float travelTime;
    public Transform platformA;
    public Transform platformB;

    float speed, time;
    void Start()
    {
        transform.position = platformA.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceAB =(platformB.position - transform.position).magnitude;
        speed = distanceAB / travelTime;
        Vector3 direction = (platformA.position - transform.position).normalized;
        Vector3 P0 = platformA.position;
        Vector3 V0 = speed * direction;

        time += Time.deltaTime;
        transform.position = kinematic.MovimientoRectilinioUniforme(time,P0,V0);
    }
}
