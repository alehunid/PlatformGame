using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheDoor : MonoBehaviour {

    /* Direction:
     * Attach collider to door object
     * Turn on isTrigger on door object
     * Attach this script to door object (Specify scene you want to load in SceneName field)
     * Attach PlayerState to player object
     * Moves on to next scene if key_found in PlayerState is true
     * 
     * If you get an error related to "build settings":
     * 1. Go to Unity and open the scene you want to load
     * 2. Go to File > Build Setting
     * 3. Click "Add Open Scene"
     * 4. Click "Build"
     * 5. Run again
     */

    public string SceneName; //Lets you enter scene name from Unity

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if this gameObject detects the player 
        //gameObject will apply the following effect if player contains key
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerState script = collision.gameObject.GetComponent<PlayerState>(); //checks player script
            if (script.key_found == true) //checks to see if key has been found
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }
}
