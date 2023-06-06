using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    public void GoBack()
    {
        // loads main menu
        SceneManager.LoadScene("Main_Menu");
    }

}
