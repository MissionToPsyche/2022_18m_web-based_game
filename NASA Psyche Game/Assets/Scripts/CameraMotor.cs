using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    //  Fields  //
    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    //  Methods  //
    // Update is called once per frame
    private void LateUpdate()
    {
        //  Variables   //
        Vector3 delta = Vector3.zero;

        //Checks if we're inside the bounds on the X axis
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        //Checks if we're inside the bounds on the Y axis
        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
