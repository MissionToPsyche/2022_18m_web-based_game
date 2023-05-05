using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WiringMinigameTrigger : Collidable
{
    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            // scene 4 is the wiring minigame
            SceneManager.LoadScene("Basic_Wiring");
            gameObject.SetActive(false);
        }
    }
}
