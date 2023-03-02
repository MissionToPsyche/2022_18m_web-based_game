using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //  Fields   //
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

    private Animator animator;
    private Transform myTransform;
    private Vector3 lastPos;

    //  Methods   //
    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        animator = gameObject.GetComponent<Animator>();
        myTransform = transform;
        lastPos = myTransform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // Variables //
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // Body //
        //Reset MoveDelta
        moveDelta = new Vector3(x,y,0);

        //Swap sprite direction, wether you're going right or left
        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        //Make sure we can move in the Y direction, by casting a box their first. If null, can move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this thing move!
            transform.Translate(0, moveDelta.y * Time.deltaTime * 5, 0);
        }

        //Make sure we can move in the X direction, by casting a box their first. If null, can move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this thing move!
            transform.Translate(moveDelta.x * Time.deltaTime  * 5, 0, 0);
        }

        if (myTransform.position != lastPos) {
            animator.SetBool("isWalking", true);
        }
        else {
            animator.SetBool("isWalking", false);
        }
        lastPos = myTransform.position;
    }

}
