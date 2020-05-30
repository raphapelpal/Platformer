using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Phase_1");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
