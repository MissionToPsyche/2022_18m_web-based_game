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

        // checks if the item can be added to the inventory
        public bool CanAddItem() {
            if (count < maxAllowed) {
                return true;
            }
            return false;
        }

        // adds item to the slot by assigning the type, icon, and item object
        public void AddItem(Item item) {
            this.type = item.type;
            this.icon = item.icon;
            this.itemInSlot = item;
            count++;
        }

        // getter for item in slot
        public Item getItem() {
            return itemInSlot;
        }
    }

    // intiialize list of slots
    public List<Slot> slots = new List<Slot>();

    // initializes inventory object with assigned number of slots
    public Inventory(int numSlots) {
        for(int i = 0; i < numSlots; i++) {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }

    // add item to its corresponding slot
    public void Add(Item item) {
        slots[item.collectableID].AddItem(item);
    }
}
