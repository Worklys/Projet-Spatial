using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadParty (string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void LoadOver (string GameOver)
    {
        SceneManager.LoadScene(GameOver);
    }

    public void LoadMenu (string Menu)
    {
        SceneManager.LoadScene(Menu);
    }

    public void LoadIntro(string IntroMenu)
    {
        SceneManager.LoadScene(IntroMenu);
    }

    public void LoadIntroSeconde(string IntroSecond)
    {
        SceneManager.LoadScene(IntroSecond);
    }

    public void LoadQuit (){

        Application.Quit ();
        Debug.Log("Poka Poka");
    }
}
