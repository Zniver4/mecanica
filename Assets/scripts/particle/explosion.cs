using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public Vector3 initialPosition, inicialVelocity;
    public GameObject particlePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject particle = Instantiate(particlePrefab, initialPosition, Quaternion.identity);
            particle.transform.position = Random.insideUnitCircle * 360;
            particle.GetComponent<particle>().P0 = initialPosition;
            particle.GetComponent<particle>().V0 = inicialVelocity;
            Destroy(particle, 10f);
        }
    }
}
