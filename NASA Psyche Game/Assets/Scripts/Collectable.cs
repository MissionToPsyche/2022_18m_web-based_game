using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable {
    protected bool collected;

    public CollectableType type;

    public Sprite icon;

    protected override void OnCollide(Collider2D coll) {
        // if (coll.name == "Psychenaut") {
        //     OnCollect();
        // }

        Player player = coll.GetComponent<Player>();

        if (player) {
            player.inventory.Add(this);
            OnCollect();
        }
    }

    protected virtual void OnCollect() {
        collected = true;
    }
}

public enum CollectableType {
    NONE, PART
}