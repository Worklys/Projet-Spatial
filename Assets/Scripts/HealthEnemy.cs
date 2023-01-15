using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthEnemy : MonoBehaviour
{
    public float vie = 100f;
    public float vieMax = 100f;
    public TextMeshProUGUI lifeText;
    public Slider lifeBarre;
    public GameObject EnemyPrefab;
    private float timer = 0.0f;
    private float waitTime = 0.5f;

    private bool isTrigger = false;

    void Start()
    {
        lifeText.text = vieMax.ToString();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            timer = 0.0f;
            if (isTrigger)
            {
                vie -= 10;
                lifeText.text = vie.ToString();
                lifeBarre.value = vie / 10;
                print("ohoh");

            }
            if (vie <= 0)
            {

                EnemyPrefab.SetActive(false);
                Destroy(gameObject);
            }

        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lazer")
        {
            isTrigger = true;
            vie -= 10;
            print("je suis touché");
        }
    }
        void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Lazer")
            {
                isTrigger = false;
            print("je suis pas touché");
        }
    }
}