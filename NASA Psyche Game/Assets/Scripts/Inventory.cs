using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    [System.Serializable]
    public class Slot {
        public CollectableType type;
        public int count;
        public int maxAllowed;

        public Sprite icon;

        public Item itemInSlot;

        public Slot() {
            type = CollectableType.NONE;
            count = 0;
            maxAllowed = 1;
        }

        public bool CanAddItem() {
            if (count < maxAllowed) {
                return true;
            }
            return false;
        }

        public void AddItem(Item item) {
            this.type = item.type;
            this.icon = item.icon;
            this.itemInSlot = item;
            count++;
        }

        public Item getItem() {
            return itemInSlot;
        }
    }

    public List<Slot> slots = new List<Slot>();

    public Inventory(int numSlots) {
        for(int i = 0; i < numSlots; i++) {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }

    public void Add(Item item) {
        slots[item.collectableID].AddItem(item);
    }

    // public void removeRespawnedItems() {
    //     GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //     for (int i = 0; i < slots.Count; i++) {
    //         if (slots[i].type.ToString() == "PART") {
    //             Item curItem = slots[i].getItem();
    //             UnityEngine.Object.Destroy(GameObject.Find(curItem.itemName));
    //         }
    //     }
    // }
}
