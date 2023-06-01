using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPoster : Collidable {
    public PosterManager posterManager;

    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            posterManager.StartDialogue();
            gameObject.SetActive(false);
            Invoke("showObject", 5.0f);
        }
    }

    private void showObject() {
        gameObject.SetActive(true);
    }
}