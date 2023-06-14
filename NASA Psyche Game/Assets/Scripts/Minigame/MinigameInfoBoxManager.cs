using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameInfoBoxManager : MonoBehaviour
{
    public GameObject diaBox;

    // Start is called before the first frame update
    void Start()
    {
        diaBox.SetActive(true);
    }

    // if the textbox is active and spacebar is pressed, close the textbox
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && diaBox.activeSelf == true) {
            EndDialogue();
        }
    }

    // display textbox
    public void StartDialogue() {
        diaBox.SetActive(true);
    }

    // hide textbox
    public void EndDialogue() {
        diaBox.SetActive(false);
    }
}