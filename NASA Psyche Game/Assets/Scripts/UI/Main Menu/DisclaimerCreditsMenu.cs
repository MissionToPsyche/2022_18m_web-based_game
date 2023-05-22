using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisclaimerCreditsMenu : MonoBehaviour
{
    public void GoBack()
    {
        // loads level with the next index in the build manages (menu = 0, controls = 1, warehouse = 2)
        SceneManager.LoadScene("Main_Menu");
    }

}
