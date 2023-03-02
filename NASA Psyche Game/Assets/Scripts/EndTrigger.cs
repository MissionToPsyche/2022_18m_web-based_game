using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndTrigger : Collidable
{
    public int endScore;
    protected override void OnCollide(Collider2D coll) {
        int currentScore = FindObjectOfType<ScoreManager>().score;

        if (coll.name == "Psychenaut" && currentScore == endScore) {
            GetComponent<DialogueTrigger>().TriggerDialogue();
            gameObject.SetActive(false);
        }
    }
}
