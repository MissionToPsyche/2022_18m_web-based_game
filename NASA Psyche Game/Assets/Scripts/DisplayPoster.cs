using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPoster : Collidable {
    public PosterManager posterManager;

    // if the player collides with the trigger, display the poster's image
    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            // show poster
            posterManager.StartDialogue();
            gameObject.SetActive(false);
            // disable trigger for 5 seconds to avoid spamming the player
            Invoke("showObject", 5.0f);
        }
    }

    // shows trigger
    private void showObject() {
        gameObject.SetActive(true);
    }
}