using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Quitgame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void level1()
    {
        SceneManager.LoadScene("Scene01");
        
    }

    public void level2()
    {
        SceneManager.LoadScene("Level2");

    }

}
