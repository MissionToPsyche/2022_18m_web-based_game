using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisclaimerCreditsMenu : MonoBehaviour
{
    public void GoBack()
    {
        // loads main menu scene
        SceneManager.LoadScene("Main_Menu");
    }

}
