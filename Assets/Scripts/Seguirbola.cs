using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguirbola : MonoBehaviour
{
    public Transform bola; // Asigna la bola que deseas seguir desde el Inspector

    void Update()
    {
        if (bola != null)
        {
            Vector3 nuevaPosicion = new Vector3(bola.position.x, bola.position.y+5, bola.position.z-10);
            transform.position = nuevaPosicion;
        }
    }
}
