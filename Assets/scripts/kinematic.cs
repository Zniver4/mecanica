using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinematic
{
   public static Vector3 MovimientoRectilinioUniforme(float time, Vector3 initialPosition, Vector3 initialVelocity)
    {
        return initialVelocity * time + initialPosition;
    }
}
