using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable {
    protected bool collected;

    public CollectableType type;

    public Sprite icon;

    public int collectableID;

    // when the player contacts the collectable item, process collection
    protected override void OnCollide(Collider2D coll) {
        Player player = coll.GetComponent<Player>();

        if (player) {
            OnCollect();
        }
    }

    // method that is run when an item is contacted
    protected virtual void OnCollect() {
        collected = true;
    }

    // setter for item ID
    public void setID(int id) {
        this.collectableID = id;
    }
}

// enumerable types for collectables 
public enum CollectableType {
    NONE, PART
}