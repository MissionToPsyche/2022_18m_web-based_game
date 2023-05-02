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
        base.setID(itemID);
        // Debug.Log("collectableID: " + this.collectableID);

        Player player = coll.GetComponent<Player>();

        if (player) {
            player.inventory.Add(this);
            OnCollect();
        }
    }

    protected override void OnCollect() {
        if (!collected) {
            collected = true;

            // base.setID(itemID);
            // Debug.Log("collectableID: " + this.collectableID);

            // GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

            FindObjectOfType<ScoreManager>().AddPoint(itemValueAmount);

            GetComponent<DialogueTrigger>().TriggerDialogue(itemName, description, itemIcon);

            Destroy(this.gameObject);
        }
    }
}
