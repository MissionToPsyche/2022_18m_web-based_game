using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiringMinigameWarningManager : MonoBehaviour
{
    public GameObject diaBox;
    public GameObject wiringMinigameTrigger;

    // Start is called before the first frame update
    void Start()
    {
        diaBox.SetActive(false);
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

    // disables the minigame trigger for 5 seconds
    public void TempDeactivateTrigger() {
        wiringMinigameTrigger.SetActive(false);
        StartDialogue();
        Invoke("showObject", 5.0f);
    }

    // enables the minigame trigger
    void showObject() {
        wiringMinigameTrigger.SetActive(true);
    }
}