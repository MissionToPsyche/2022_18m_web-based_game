using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WiringMinigameTrigger : Collidable
{
    public GameObject pointWarningDialogueBox;

    protected override void OnCollide(Collider2D coll) {
        int currentScore = FindObjectOfType<ScoreManager>().score;
        int endScore = FindObjectOfType<ScoreManager>().endScore;
        if (coll.name == "Psychenaut" && currentScore == endScore) {
            SaveGameInfoForMinigame.saveCurrentInfo();
            SceneManager.LoadScene("Basic_Wiring");
            gameObject.SetActive(false);
        }
        else if (coll.name == "Psychenaut" && currentScore != endScore){
            FindObjectOfType<WiringMinigameWarningManager>().TempDeactivateTrigger();
        }
    }
}
