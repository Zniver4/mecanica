using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicBullet : MonoBehaviour
{
    public Vector3 P0, V0;
    float t;
    
    void Update()
    {
        t += Time.deltaTime;
        transform.position = Parabolicshot.position(t, P0, V0);
        transform.forward = Parabolicshot.Velocity(t, P0, V0);
    }

}
