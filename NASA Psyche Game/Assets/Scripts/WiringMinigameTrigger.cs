using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WiringMinigameTrigger : Collidable
{
    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            SceneManager.LoadScene(3);
            gameObject.SetActive(false);
        }
    }
}
