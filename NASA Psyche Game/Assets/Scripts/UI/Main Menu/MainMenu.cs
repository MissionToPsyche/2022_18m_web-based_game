using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start() {
        // hides in game UI at the start of the game
        FindObjectOfType<ScoreManager>().DisableText();
        FindObjectOfType<HelpButton>().HideButton();
    }

    public void PlayGame()
    {
        // loads warehouse scene
        SceneManager.LoadScene("Warehouse");
        FindObjectOfType<ScoreManager>().EnableText();
        FindObjectOfType<HelpButton>().ShowButton();
    }

    public void QuitGame()
    {
        // Exits Game 
        Application.Quit();
    }

    public void OpenSettings()
    {
        // loads controls menu
        SceneManager.LoadScene("Controls_Menu");
    }

    public void OpenDisclaimer() {
        // loads disclaimer menu
        SceneManager.LoadScene("Disclaimer_Menu");
    }
}
