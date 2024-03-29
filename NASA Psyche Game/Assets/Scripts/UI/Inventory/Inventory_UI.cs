using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public Player player;
    public List<Slot_UI> slots = new List<Slot_UI>();

    void Start() {
        inventoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if tab or I are pressed, toggle the inventory
        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.I)) {
            ToggleInventory();
        }
    }

    // If the inventory is not active, show it. Otherwise, hide it.
    public void ToggleInventory() {
        if (!inventoryPanel.activeSelf) {
            inventoryPanel.SetActive(true);
            Setup();
        }
        else {
            inventoryPanel.SetActive(false);
        }
    }

    // populare each inventory slot with their corresponding items, if obtained
    void Setup() {
        if (slots.Count == player.inventory.slots.Count) {
            for (int i = 0; i < slots.Count; i++) {
                if (player.inventory.slots[i].type != CollectableType.NONE) {
                    slots[i].SetItem(player.inventory.slots[i]);
                }
                else {
                    slots[i].SetEmpty();
                }
            }
        }
    }
}
