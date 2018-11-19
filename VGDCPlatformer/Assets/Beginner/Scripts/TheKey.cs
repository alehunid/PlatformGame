using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheKey : MonoBehaviour {

    /* Direction:
     * Attach collider to key object
     * Turn on isTrigger on key object
     * Attach this script to key object
     * Attach PlayerState to player object
     * Changes key_found in PlayerState script to true after collision with key object
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if this gameObject detects the player 
        //gameObject will be destroyed
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerState script = collision.gameObject.GetComponent<PlayerState>(); //checks player script
            if (script.key_found == false) //checks to see if key has been found
            {
                script.key_found = true;
            }
            Destroy(gameObject); // destroys Key to simulate picking up
        }
    }
}
