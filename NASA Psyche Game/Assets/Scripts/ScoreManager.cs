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
        GameObject itemDialogueBox = GameObject.Find("DialogueBox");
        if (score == endScore && allCollected == false && SaveGameInfoForMinigame.newGame == true) { // 
            if (!itemDialogueBox) {
                Debug.Log("ATTEMPTING TO PRINT");
                // StartDialogue();
                Invoke("StartDialogue", 0.1f);
                allCollected = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && allCollectedDialogueBox.activeSelf == true) { //  
            EndDialogue();
            Debug.Log("ended through space");
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
        Debug.Log("ended normally");
    }
} 
