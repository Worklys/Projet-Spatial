using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject OverMenu;
    public bool GOMenu = false;


    public static GameOver Instance;


    void start(){

        if(Instance == null)
        {
            Instance = this;
        }


    }

   public void LooseGameOver(){
  		    
		    OverMenu.SetActive(true);
            GOMenu = true;
  	}
}
