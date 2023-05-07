using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveGameInfoForMinigame {
    public static Vector3 playerCurrentPos = new Vector3(0, 0, 0);
    public static Inventory currentInventory = new Inventory(9);
    public static int currentScore = 0;
    public static bool newGame = true;

    public static void saveCurrentInfo() {
        GameObject playerObj = GameObject.Find("Psychenaut");
        playerCurrentPos = playerObj.transform.position;
        currentInventory = GameObject.FindObjectOfType<Player>().inventory;
        currentScore = GameObject.FindObjectOfType<ScoreManager>().score;
        newGame = false;
    }

    public static void loadCurrentInfo() {
        GameObject playerObj = GameObject.Find("Psychenaut");
        if (!newGame) {
            GameObject.Find("Wiring Minigame Trigger").SetActive(false);
            playerObj.transform.position = playerCurrentPos;
            GameObject.FindObjectOfType<Player>().inventory = currentInventory;
            GameObject.FindObjectOfType<ScoreManager>().score = currentScore;

            GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
            for (int i = 0; i < GameObject.FindObjectOfType<Player>().inventory.slots.Count; i++) {
                if (GameObject.FindObjectOfType<Player>().inventory.slots[i].type.ToString() == "PART") {
                    Item curItem = GameObject.FindObjectOfType<Player>().inventory.slots[i].getItem();
                    UnityEngine.Object.Destroy(GameObject.Find(curItem.itemName));
                }
            }
        }
        // GameObject.FindObjectOfType<Player>().inventory.removeRespawnedItems();
        
    }
}