using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : Collectable
{
    public int itemValueAmount = 1;
    public string itemName;

    [TextArea(3, 10)]
    public string[] description;

    protected override void OnCollect() {
        if (!collected) {
            collected = true;

            // GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

            FindObjectOfType<ScoreManager>().AddPoint(itemValueAmount);

            GetComponent<DialogueTrigger>().TriggerDialogue(itemName, description);

            Destroy(this.gameObject);
        }
    }
}
