using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    // set the object's collider when the game starts
    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // process collisions between the current object's collider and another collider
    protected virtual void Update()
    {
        boxCollider.OverlapCollider(filter, hits);
        // loop through all hits
        for (int i = 0; i < hits.Length; i++)
        {
            // skip hits that are null
            if (hits[i] == null)
            {
                continue;
            }

            // run OnCollide whenever there is a hit
            OnCollide(hits[i]);
            // set the processed hit as null
            hits[i] = null;
        }
    }

    // method that is run whenever the two colliders contact one another
    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }
}
