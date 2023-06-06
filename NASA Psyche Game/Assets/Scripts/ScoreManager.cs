using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    public GameObject allCollectedDialogueBox;
    public bool allCollected = false;

    public int score = 0;

    public int endScore;

    private void Awake() {
        instance = this;
    }
    
    // initialize score label and hide "all collected" message
    void Start() {
        allCollected = false;
        scoreText.text = "Items collected: " + score.ToString() + "/" + endScore.ToString();
        allCollectedDialogueBox.SetActive(false);
    }

    void Update() {
        GameObject itemDialogueBox = GameObject.Find("DialogueBox");
        // if all items are collected and the warehouse has never been reloaded, display "all collected" message
        if (score == endScore && allCollected == false && SaveGameInfoForMinigame.newGame == true) { 
            if (!itemDialogueBox) {
                Invoke("StartDialogue", 0.1f);
                allCollected = true;
            }
        }

        // if the textbox is active and the spacebar is pressed, advance text
        if (Input.GetKeyDown(KeyCode.Space) && allCollectedDialogueBox.activeSelf == true) { 
            EndDialogue();
        }
    }

    // add point to score
    public void AddPoint(int point) {
        score += point;
        scoreText.text = "Items collected: " + score.ToString() + "/" + endScore.ToString();
    }

    // hide score readout
    public void DisableText() {
        scoreText.gameObject.SetActive(false);
    }

    // show score readout
    public void EnableText() {
        scoreText.gameObject.SetActive(true);
    }

    // show textbox
    public void StartDialogue() {
        allCollectedDialogueBox.SetActive(true);
    }

    // hide textbox
    public void EndDialogue() {
        allCollectedDialogueBox.SetActive(false);
    }
} 
