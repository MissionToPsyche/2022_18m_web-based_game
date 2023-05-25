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
    
    void Start() {
        allCollected = false;
        scoreText.text = "Items collected: " + score.ToString() + "/" + endScore.ToString();
        allCollectedDialogueBox.SetActive(false);
    }

    void Update() {
        if (score == endScore && allCollected == false && SaveGameInfoForMinigame.newGame == true) {
            GameObject itemDialogueBox = GameObject.Find("DialogueBox");
            if (!itemDialogueBox) {
                allCollected = true;
                StartDialogue();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && allCollectedDialogueBox.activeSelf == true) {
            EndDialogue();
        }
    }

    public void AddPoint(int point) {
        score += point;
        scoreText.text = "Items collected: " + score.ToString() + "/" + endScore.ToString();
    }

    public void DisableText() {
        // Debug.Log("text disabled");
        scoreText.gameObject.SetActive(false);
    }

    public void EnableText() {
        // Debug.Log("text enabled");
        scoreText.gameObject.SetActive(true);
    }

    public void StartDialogue() {
        allCollectedDialogueBox.SetActive(true);
    }

    public void EndDialogue() {
        allCollectedDialogueBox.SetActive(false);
    }
} 
