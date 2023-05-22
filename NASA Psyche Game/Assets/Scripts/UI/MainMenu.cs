using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start() {
        FindObjectOfType<ScoreManager>().DisableText();
    }

    public void PlayGame()
    {
        // loads level with the next index in the build manages (Main_Menu = 0, Controls_Menu = 1, Disclaimer_Menu = 2, Warehouse = 3, Basic_Wiring = 4)
        SceneManager.LoadScene("Warehouse");
        FindObjectOfType<ScoreManager>().EnableText();
    }

    public void QuitGame()
    {
        // Exits Game 
        Application.Quit();
    }

    public void OpenSettings()
    {
        // Temporary, once more complicated controls/tutorials need to be added,
        //   edit this function
        SceneManager.LoadScene("Controls_Menu");
        //SceneManager.LoadScene("Settings");
    }

    public void OpenDisclaimer() {
        SceneManager.LoadScene("Disclaimer_Menu");
    }
}
