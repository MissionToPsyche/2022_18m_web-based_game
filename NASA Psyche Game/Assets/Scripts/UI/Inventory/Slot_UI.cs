using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slot_UI : MonoBehaviour
{
    public Image itemIcon;
    
    // sets the slot's image to the item image
    public void SetItem(Inventory.Slot slot) {
        if (slot != null) {
            itemIcon.sprite = slot.icon;
            itemIcon.color = new Color(1, 1, 1, 1);
        }
    }

    // removes the slot's image
    public void SetEmpty() {
        itemIcon.sprite = null;
        itemIcon.color = new Color(1, 1, 1, 0);
    }
}
