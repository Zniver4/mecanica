using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    public float t;

    public Vector3 P0, V0;
    void Update()
    {
        t += Time.deltaTime;
        transform.position = kinematic.MovimientoRectilinioUniforme(t,P0,V0);
    }
}
