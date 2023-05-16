using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameController : MonoBehaviour
{
    public VictoryMessage victoryMessage;

    public int targetVictoryPoints;
    int victoryPoints = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddVictoryPoints(int addedPoints)
    {
        victoryPoints += addedPoints;

        CheckVictory();
    }

    void CheckVictory()
    {
        //if reached victory condition
        if (victoryPoints == targetVictoryPoints)
        {
            //create a victory message
            DisplayVictory();
        }
    }

    void DisplayVictory()
    {
        victoryMessage.display();
    }

    // public static void DisplayInfo() {
    //     FindObjectOfType<InfoPopupManager>().StartDialogue();
    // }
}

