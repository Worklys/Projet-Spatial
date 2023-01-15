using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestPoint : MonoBehaviour
{
    public float point  = 0f;
    public TextMeshProUGUI pointMax;
    public static TestPoint Instance;




    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            point++;
            pointMax.text = point.ToString();
        }
    }
}
