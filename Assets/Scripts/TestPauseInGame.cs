using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPauseInGame : MonoBehaviour
{
  public static TestPauseInGame Instance;
  public GameObject Menu;
  public bool inMenu = false;


    void Start()
    {
        if(Instance == null){

          Instance = this;
        }

    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale != 0){

        Time.timeScale = 0;
        Menu.SetActive(true);
        inMenu = true;
      }
      else if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0){

        Menu.SetActive(false);
        inMenu = false;
        Time.timeScale =1;

      }
    }
}
