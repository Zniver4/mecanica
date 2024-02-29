using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlespawner : MonoBehaviour
{
    public Vector3 initialPosition, inicialVelocity;
    public GameObject particlePrefab;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            GameObject particle = Instantiate(particlePrefab, initialPosition, Quaternion.identity);
            particle.GetComponent<particle>().P0 = initialPosition;
            particle.GetComponent<particle>().V0 = inicialVelocity;
            Destroy(particle, 10f);
        }
    }
}
