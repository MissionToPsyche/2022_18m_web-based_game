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

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && diaBox.activeSelf == true) {
            EndDialogue();
        }
    }

    public void StartDialogue() {
        diaBox.SetActive(true);
    }

    public void EndDialogue() {
        diaBox.SetActive(false);
    }

    public void ShowButton() {
        helpButton.SetActive(true);
    }

    public void HideButton() {
        helpButton.SetActive(false);
    }
}