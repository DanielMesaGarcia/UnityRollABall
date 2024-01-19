using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int points = 10; // Puntos que se sumarán al contacto

    void Update()
    {
        transform.Rotate(new Vector3(30, 45, 85) * Time.deltaTime);
    }

    // Cuando otro objeto colisiona con este objeto
    void OnTriggerEnter(Collider other)
    {
        ScoreManage scoreManager = FindObjectOfType<ScoreManage>();
            if (scoreManager != null)
            {
                scoreManager.AddPoints(points);
            }

            gameObject.SetActive(false);
        
    }

}
