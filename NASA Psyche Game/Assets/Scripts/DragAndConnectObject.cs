using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndConnectObject : MonoBehaviour
{
    //public SpriteRenderer wireStraight;
    public LineRenderer line;

    Vector3 startPos;
    Vector3 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPos = transform.position;
    }

    // Navigate Mouse Dragging
    private void OnMouseDrag()
    {
        //Get mouse and Update wire extention
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0;

        //check for connections
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPos, .2f);
        foreach (Collider2D collider in colliders)
        {
            //if not self, update
            if (collider.gameObject != gameObject)
            {
                UpdateWire(collider.transform.position);

                //check if same color
                if (transform.parent.name.Equals(collider.transform.parent.name))
                {
                    MinigameController.AddVictoryPoints(1);
                    SuccesfulConnection(collider);
                }
                return;
            }
        }
        UpdateWire(newPos);
    }

    // Resets wire if no connection found
    private void OnMouseUp()
    {
        UpdateWire(startPos);
    }

    void UpdateWire(Vector3 newPos)
    {
        //sets new position
        transform.position = newPos;

        //Calculate and Update the direction the wire head should be facing
        //Vector3 direction = newPos - startPoint;
        //transform.right = direction * transform.lossyScale.x;

        //scales
        float dist = Vector2.Distance(startPoint, newPos);
        //wireStraight.size = new Vector2(dist, wireStraight.size.y);

        ////// NEW STUFFS //////
        //Updates extendable wire
        Vector3 frontLine = new Vector3(gameObject.transform.position.x - .1f, gameObject.transform.position.y, gameObject.transform.position.z);
        Vector3 backLine = new Vector3(gameObject.transform.position.x - .4f, gameObject.transform.position.y, gameObject.transform.position.z);

        line.SetPosition(3, frontLine);
        line.SetPosition(2, backLine);
    }

    void SuccesfulConnection(Collider2D matchingWire)
    {
        //lock wire
        Destroy(this);

        //lock connecting wire
        Destroy(matchingWire);
    }
}

