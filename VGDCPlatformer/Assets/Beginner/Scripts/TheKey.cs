using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheKey : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if this gameObject detects the player 
        //gameObject will be destroyed
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroys Key to simulate picking up
        }
    }
}
