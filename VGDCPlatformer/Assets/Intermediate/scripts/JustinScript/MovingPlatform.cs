using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    //manages platform movement at different points
    [Header("Platform Positions")]
    public Transform movingPlatform; //platform gameObject that we will be moving

    /*Points where the platform  will move*/
    public Transform position1; 
    public Transform position2;
    public Transform position3;

    [HideInInspector] public Vector3 newPosition; //(X, Y, Z) coordinates of the platform

    [Space]

    [Header("Platform Attributes")]
    public string state; //named states on where the platform should move
    
    /*Adjusted speeds for the platform movement */
    public float platformVelocity;
    public float movementTime;

    void Start()
    {
        //initally the platform will start at some state
        ChangeTarget();
    }

    void FixedUpdate()
    {
        //update the movement of the platform
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, platformVelocity * Time.deltaTime);
    }

    void ChangeTarget()
    {
        /*check states and move platform, then we change states to update
        postion of the moving platform */

        //state names are abritrary and can program more 
        //states and positions if needed
        if (state == "right1")
        {
            state = "right2";
            newPosition = position2.position;
            movementTime = 1;
            Debug.Log("right1");
        }
        else if (state == "right2")
        {
            state = "left1";
            newPosition = position3.position;
            movementTime = 2;
            Debug.Log("right2");
        }
        else if (state == "left1")
        {
            state = "left2";
            newPosition = position2.position;
            movementTime = 1;
            Debug.Log("left1");
        }
        else if (state == "left2")
        {
            state = "right1";
            newPosition = position1.position;
            movementTime = 2;
            Debug.Log("left2");
        }
        else if (state == "start")
        {
            state = "right2";
            newPosition = position2.position;
            movementTime = 1;
            Debug.Log("start");
        }
        else if (state == "stop") //default position
        {
            newPosition = position1.position;
            movementTime = 0;
            if (Input.GetButton("Fire1"))
            {
                state = "right1";
                Debug.Log("Fire1");
            }
        }
        Invoke("ChangeTarget", movementTime);
    }

}
