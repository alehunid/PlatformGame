using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBound : MonoBehaviour {

    /*Direction:
     * Place a collider in out of bound area
     * Turn on isTrigger on collider
     * Attach this script to GameObject
     * Create another GameObject and specify it as respawn point
     * Select the respawn point GameObject in the spawnPoint field 
     */

    [SerializeField] Transform spawnPoint; //Lets you enter spawnPoint from Unity

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //If Player object enters Out Of Bounds
        {
            collision.transform.position = spawnPoint.position; //Teleport from OutOfBounds area to spawnPoint coordinates
        }
    }
}
