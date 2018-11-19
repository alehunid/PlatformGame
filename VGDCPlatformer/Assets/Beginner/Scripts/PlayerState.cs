using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    /* Direction:
     * Attach this script to player object
     * Attach TheKey script to key object
     * Changes key_found to true after finding the key
    */

    public bool key_found; // initializes key_found
    
	// Use this for initialization
	void Start () {
        key_found = false; //sets key_found to false at start of scene
	}
}
