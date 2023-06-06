using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPopupManager : MonoBehaviour
{
    public GameObject diaBox;

    // Start is called before the first frame update
    void Start()
    {
        // hide textbox
        diaBox.SetActive(false);
    }

    // if the textbox is active and the spacebar is pressed, advance text
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && diaBox.activeSelf == true) {
            EndDialogue();
        }
    }

    // show textbox
    public void StartDialogue() {
        diaBox.SetActive(true);
    }

    // hide textbox
    public void EndDialogue() {
        diaBox.SetActive(false);
    }
}
