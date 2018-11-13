using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBound : MonoBehaviour {
    [SerializeField] Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //If Player enters Out Of Bounds
        {
            collision.transform.position = spawnPoint.position; // Teleport from OutOfBounds to Respawn Point
        }
    }
}
