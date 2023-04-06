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
        // loads level with the next index in the build manages (menu = 0, controls = 1, warehouse = 2)
        SceneManager.LoadScene(2);
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
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Settings");
    }
}
