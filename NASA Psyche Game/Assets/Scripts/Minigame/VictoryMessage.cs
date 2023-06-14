using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryMessage : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // display minigame win textbox
    public void display()
    {
        gameObject.SetActive(true);
    }

    // return to warehouse scene
    public void OnMouseUp()
    {
        SceneManager.LoadScene("Warehouse");
    }
}
