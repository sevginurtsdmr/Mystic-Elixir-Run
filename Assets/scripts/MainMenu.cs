using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SkorMenu()
    {
        SceneManager.LoadScene("Skor");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
