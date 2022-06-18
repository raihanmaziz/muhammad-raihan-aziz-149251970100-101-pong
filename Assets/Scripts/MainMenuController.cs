using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Muhammad Raihan Aziz - 149251970100-101");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void CreditGame()
    {
        SceneManager.LoadScene("Credit");
    }
}
