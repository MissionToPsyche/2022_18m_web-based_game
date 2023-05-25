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
}
