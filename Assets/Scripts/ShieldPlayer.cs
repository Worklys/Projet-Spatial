using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShieldPlayer : MonoBehaviour
{


    public float shield = 100f;
    public float shieldMax = 100f;
    public TextMeshProUGUI shieldText;
    public Slider lifeShield;
    public GameObject bouclier;
    private float timer = 0.0f;
    private float waitTime = 0.5f;


    private bool isTrigger = false;

    void Start()
    {
        shieldText.text = shieldMax.ToString();
        bouclier.SetActive(false);
    }

    void Update()
    {

       if (Input.GetKeyDown(KeyCode.T))
        {
            bouclier.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            bouclier.SetActive(false);
        }
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            timer = 0.0f;
            if (isTrigger)
            {
                shield -= 10;
                shieldText.text = shield.ToString();
                lifeShield.value = shield / 100;
                print("ihih");

            }
            if (shield <= 0)
            {

                bouclier.SetActive(false);
            }
        }


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isTrigger = true;
            shield -= 10;
            print("Bouclier en baisse");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isTrigger = false;
            print("Bouclier intacte");
        }
    }

}
