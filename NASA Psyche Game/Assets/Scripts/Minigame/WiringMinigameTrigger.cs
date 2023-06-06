using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WiringMinigameTrigger : Collidable
{
    public GameObject pointWarningDialogueBox;

    // method that is run when the player reaches the minigame trigger
    protected override void OnCollide(Collider2D coll) {
        // get current score and end score
        int currentScore = FindObjectOfType<ScoreManager>().score;
        int endScore = FindObjectOfType<ScoreManager>().endScore;

        // if the player collided with the trigger and all items are collected, start minigame
        if (coll.name == "Psychenaut" && currentScore == endScore) {
            // save current game info for later loading
            SaveGameInfoForMinigame.saveCurrentInfo();
            // switch scenes
            SceneManager.LoadScene("Basic_Wiring");
            gameObject.SetActive(false);
        }
        // if the player collided with the trigger but not all items are collected, display warning and temporarily disable minigame collider
        else if (coll.name == "Psychenaut" && currentScore != endScore){
            FindObjectOfType<WiringMinigameWarningManager>().TempDeactivateTrigger();
        }
    }
}
