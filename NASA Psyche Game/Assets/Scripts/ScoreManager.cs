using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    public int score = 0;

    public int endScore;

    private void Awake() {
        instance = this;
    }
    
    void Start() {
        scoreText.text = "Items collected: " + score.ToString() + "/" + endScore.ToString();
    }

    public void AddPoint(int point) {
        score += point;
        scoreText.text = "Items collected: " + score.ToString() + "/" + endScore.ToString();
    }
} 
