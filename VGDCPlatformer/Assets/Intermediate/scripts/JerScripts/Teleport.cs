using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    /**
     * This script is used to move the player from this object to the portal object specified.
     * */


    //SET THESE VARIABLES WITHIN UNITY (this script in the object's asset area)
    public GameObject Portal;        //Set this to the teleport destination (other portal object)
    public GameObject Player;        //Set this to the player

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //Function for teleportation
    public void OnTriggerEnter2D(Collider2D other) //When another obj collides with the teleporter
    {
        if (other.gameObject.tag == "Player") //If it collides with the player
        {
            //Moves player to portal location (+3 units to the right//Prevents constant teleportation)
            Player.transform.position = new Vector2(Portal.transform.position.x + 3, Portal.transform.position.y);
        }
    }              //Ask if there is a function that can set values after the collision


    //--------------------UNUSED VERSION (Has same function, but uses a timer for a delayed teleport)

    /*
    public void OnTriggerEnter2D(Collider2D other) //When another obj collides with the teleporter
    {
        if (other.gameObject.tag == "Player") //If it collides with the player
        {
            StartCoroutine(myTeleport());   //Use myTeleport function timer
        }
    }

    //Function for teleport delay
    IEnumerator myTeleport()
    {
        //Waits a second
        yield return new WaitForSeconds(1);

        //Teleports player to other portal after timer is done
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
    */

}
