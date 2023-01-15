using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public GameOver GOBix;
    public float vie = 100f;
    public float vieMax = 100f;
    public TextMeshProUGUI lifeText;

    public Slider lifeBarre;
    private float timer = 0.0f;
    private float waitTime = 0.5f;
    private bool isTrigger = false;

    void Start()
    {
        lifeText.text = vieMax.ToString();

    }

    void Update()
    {

        if (vie <= 0)
        {
            GOBix.LooseGameOver();
            Destroy(gameObject);
        }

        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            timer = 0.0f;
            if (isTrigger)
            {
                vie-=10;
                lifeText.text = vie.ToString();
                lifeBarre.value = vie / 100;
                print("");

            }

        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isTrigger = true;
            print("je suis touché");
        }
    }
        void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                isTrigger = false;
                print("je suis pas touché");
            }
    }
}