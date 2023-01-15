using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompteARebourd : MonoBehaviour
{
    bool startCount = false;
    float startTime = 0.0f;

void Update()
    {

if (Input.GetMouseButtonDown(0) )
        {
            startCount = true;
            startTime = Time.time;
        }

        if (startCount)
        {
            if (startTime + 5.0f < Time.time)
            {
                print("5 secondes depuis le clic !");
            }
        }
}
}