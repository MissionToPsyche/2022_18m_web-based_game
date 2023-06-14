using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HelpButton : MonoBehaviour {
    public GameObject diaBox;
    public GameObject helpButton;

    // Start is called before the first frame update
    void Start()
    {
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

    // show help button
    public void ShowButton() {
        helpButton.SetActive(true);
    }

    // hide help button
    public void HideButton() {
        helpButton.SetActive(false);
    }
}