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

    public void StartDialogue() {
        diaBox.SetActive(true);
    }

    public void EndDialogue() {
        diaBox.SetActive(false);
    }
}