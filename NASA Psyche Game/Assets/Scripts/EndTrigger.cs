using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : Collidable
{
    protected override void OnCollide(Collider2D coll) {
        int currentScore = FindObjectOfType<ScoreManager>().score;

        if (coll.name == "Psychenaut" && currentScore == 2) {
            GetComponent<DialogueTrigger>().TriggerDialogue();
        }
    }
}
