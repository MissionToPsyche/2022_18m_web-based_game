using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoleReset : Collidable {
    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            // play some sort of animation for the screen to reset here
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}