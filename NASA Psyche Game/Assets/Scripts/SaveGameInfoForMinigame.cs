using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveGameInfoForMinigame {
    public static Vector3 playerCurrentPos = new Vector3(0, 0, 0);
    public static Inventory currentInventory = new Inventory(9);
    public static int currentScore = 0;
    public static bool newGame = true;

    // get current position, inventory, and scores and save them for future loading
    public static void saveCurrentInfo() {
        GameObject playerObj = GameObject.Find("Psychenaut");
        playerCurrentPos = playerObj.transform.position;
        currentInventory = GameObject.FindObjectOfType<Player>().inventory;
        currentScore = GameObject.FindObjectOfType<ScoreManager>().score;
        newGame = false;
    }

    // loads stored info
    public static void loadCurrentInfo() {
        GameObject playerObj = GameObject.Find("Psychenaut");

        // if the game isn't a fresh start, load saved info
        if (!newGame) {
            // disable minigame trigger
            GameObject.Find("Wiring Minigame Trigger").SetActive(false);

            // reset player position, invnetory, and score
            playerObj.transform.position = playerCurrentPos;
            GameObject.FindObjectOfType<Player>().inventory = currentInventory;
            GameObject.FindObjectOfType<ScoreManager>().score = currentScore;

            // don't display "all items collected" popup
            GameObject.FindObjectOfType<ScoreManager>().allCollected = true;

            // iterate through already collected items, and remove them from the map
            GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
            for (int i = 0; i < GameObject.FindObjectOfType<Player>().inventory.slots.Count; i++) {
                // if the item is collected already, remove it from the map
                if (GameObject.FindObjectOfType<Player>().inventory.slots[i].type.ToString() == "PART") {
                    Item curItem = GameObject.FindObjectOfType<Player>().inventory.slots[i].getItem();
                    UnityEngine.Object.Destroy(GameObject.Find(curItem.itemName));
                }
            }

            // flip player
            GameObject.FindObjectOfType<Player>().transform.localScale = new Vector3(-1, 1, 1);

            // destroy invis wall
            var invisWall = GameObject.Find("Invisible Wall");
            invisWall.SetActive(false);

            // open doors
            GameObject topDoor = GameObject.Find("locked_door_top");
            GameObject bottomDoor = GameObject.Find("locked_door_bottom");
            Animator topDoorAnim = topDoor.GetComponent<Animator>();
            Animator botDoorAnim = bottomDoor.GetComponent<Animator>();

            topDoorAnim.Play("DoorOpen", -1, 0f);
            botDoorAnim.Play("DoorOpen", -1, 0f);
        }
    }

    // set newGame flag to true
    public static void resetGame() {
        newGame = true;
    }
}