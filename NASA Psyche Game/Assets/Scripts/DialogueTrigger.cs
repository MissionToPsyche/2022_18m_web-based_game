using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // public Dialogue dialogue;

    public void TriggerDialogue(string itemName, string[] description) {
        Dialogue diag = new Dialogue(itemName, description);
        FindObjectOfType<DialogueManager>().StartDialogue(diag);
    }
}
