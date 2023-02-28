using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Collectable
{
    public int itemValueAmount = 1;

    protected override void OnCollect() {
        if (!collected) {
            collected = true;

            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

            FindObjectOfType<ScoreManager>().AddPoint();

            GetComponent<DialogueTrigger>().TriggerDialogue();
        }
    }
}
