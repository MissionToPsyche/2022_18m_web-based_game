using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EndTrigger : Collidable
{
    public int endScore;
    public string endTitle;

    [TextArea(3, 10)]
    public string[] endMessage;

    protected override void OnCollide(Collider2D coll) {
        int currentScore = FindObjectOfType<ScoreManager>().score;

        if (coll.name == "Psychenaut" && currentScore == endScore) {
            GetComponent<DialogueTrigger>().TriggerDialogue(endTitle, endMessage);
            gameObject.SetActive(false);
        }
    }
}
 