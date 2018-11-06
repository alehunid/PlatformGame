using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour {

    public bool key_found; // initializes key_found
    GameObject key;
    
	// Use this for initialization
	void Start () {
        key_found = false; //sets key_found to false at start of scene
	}

    //will occur when player interacts with Key object
    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag == "key")
        {
            key_found = true; // set key_found to be true after key was pickd up
        }
    }
}
