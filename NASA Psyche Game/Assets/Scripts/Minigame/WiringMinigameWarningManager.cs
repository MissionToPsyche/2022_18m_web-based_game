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

    public void StartDialogue() {
        diaBox.SetActive(true);
    }

    public void EndDialogue() {
        diaBox.SetActive(false);
    }

    public void TempDeactivateTrigger() {
        wiringMinigameTrigger.SetActive(false);
        StartDialogue();
        Invoke("showObject", 5.0f);
    }

    void showObject() {
        wiringMinigameTrigger.SetActive(true);
    }
}