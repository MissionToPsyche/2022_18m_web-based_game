using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class EndTrigger : Collidable
{
    public int endScore;
    public string endTitle;

    [TextArea(3, 10)]
    public string[] endMessage;

    protected override void OnCollide(Collider2D coll) {
        // get current score/final score values
        int currentScore = FindObjectOfType<ScoreManager>().score;
        endScore = FindObjectOfType<ScoreManager>().endScore;

        // if all items are collected, play end animation
        if (coll.name == "Psychenaut" && currentScore == endScore) {

            // Switches to ending animation
            SaveGameInfoForMinigame.resetGame();
            SceneManager.LoadScene("End_Screen");
        }

        
    }
}
 