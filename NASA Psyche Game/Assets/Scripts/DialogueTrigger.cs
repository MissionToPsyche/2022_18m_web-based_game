using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    // public Dialogue dialogue;

    public void TriggerDialogue(string itemName, string[] description) {
        Dialogue diag = new Dialogue(itemName, description);
        FindObjectOfType<DialogueManager>().StartDialogue(diag);
    }

    public void TriggerDialogue(string itemName, string[] description, Sprite icon) {
        Dialogue diag = new Dialogue(itemName, description, icon);
        FindObjectOfType<DialogueManager>().StartDialogue(diag);
    }
}
