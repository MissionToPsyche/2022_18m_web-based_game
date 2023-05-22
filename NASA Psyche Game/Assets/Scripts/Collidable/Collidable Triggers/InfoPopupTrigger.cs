using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPopupTrigger : Collidable
{
    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            FindObjectOfType<InfoPopupManager>().StartDialogue();
            gameObject.SetActive(false);
        }
    }
}
