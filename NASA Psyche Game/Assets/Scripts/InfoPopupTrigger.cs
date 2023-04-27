using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPopupTrigger : Collidable
{
    // public void TriggerInfoBox() {
    //     FindObjectOfType<InfoPopupManager>().StartDialogue();
    // }

    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            FindObjectOfType<InfoPopupManager>().StartDialogue();
            gameObject.SetActive(false);
        }
    }
}
