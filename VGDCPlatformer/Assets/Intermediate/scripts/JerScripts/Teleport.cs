using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject Portal;        //Teleporter Object
    public GameObject Player;        //Player Object

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
            //StartCoroutine(myTeleport());
            Player.transform.position = new Vector2(Portal.transform.position.x + 3, Portal.transform.position.y);
        }   //Ask if there is a function that can set values after the collision
    }

    /*
    IEnumerator myTeleport()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = new Vector2(Portal.transform.position.x+3, Portal.transform.position.y);
    }
    */

}
