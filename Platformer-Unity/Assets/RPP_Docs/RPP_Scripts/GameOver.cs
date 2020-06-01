using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    static public bool level1Finished = false;

    public void ReplayGame()
    {
        if (level1Finished == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Level1Passed()
    {
        level1Finished = true;
    }
}
