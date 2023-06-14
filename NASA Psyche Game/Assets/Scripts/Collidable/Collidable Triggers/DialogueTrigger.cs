using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    // populate textbox with item information and display textbox
    public void TriggerDialogue(string itemName, string[] description) {
        Dialogue diag = new Dialogue(itemName, description);
        FindObjectOfType<DialogueManager>().StartDialogue(diag);
    }

    // populate textbox with item information and item image, and display textbox
    public void TriggerDialogue(string itemName, string[] description, Sprite icon) {
        Dialogue diag = new Dialogue(itemName, description, icon);
        FindObjectOfType<DialogueManager>().StartDialogue(diag);
    }
}
