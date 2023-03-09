using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MinigameController
{
    public static int targetVictoryPoints;
    static int victoryPoints = 0;

    public static void AddVictoryPoints(int addedPoints)
    {
        MinigameController.victoryPoints += addedPoints;

        CheckVictory();
    }

    static void CheckVictory()
    {
        //if reached victory condition
        if (victoryPoints == targetVictoryPoints)
        {
            //create a victory message
            DisplayVictory();
        }
    }

    static void DisplayVictory()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "You win!");
    }
}
