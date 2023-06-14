using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item : Collectable
{
    public int itemValueAmount = 1;
    public string itemName;
    public int itemID;

    [TextArea(3, 10)]
    public string[] description;

    public Sprite itemIcon;

    protected override void OnCollide(Collider2D coll) {
        // set ID of item
        base.setID(itemID);

        // get player object
        Player player = coll.GetComponent<Player>();

        // if the player contacted the item, add it to inventory and display textbox
        if (player) {
            player.inventory.Add(this);
            OnCollect();
        }
    }

    // processes the item as collected, displays corresponding item textbox, and destroys the gameobject
    protected override void OnCollect() {
        if (!collected) {
            collected = true;

            FindObjectOfType<ScoreManager>().AddPoint(itemValueAmount);

            GetComponent<DialogueTrigger>().TriggerDialogue(itemName, description, itemIcon);

            Destroy(this.gameObject);
        }
    }
}
