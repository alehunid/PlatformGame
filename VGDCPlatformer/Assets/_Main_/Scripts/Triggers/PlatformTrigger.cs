using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour {

    /* Directions
     * Turn on isTrigger on a collider of the intended trigger
     * Add this script as a component of the trigger
     * Put the name of the intended platform under the platformName field
     */

    private GameObject platform;
    public string platformName;

    // Use this for initialization
    void Start()
    {
        // Find the platform GameObject
        platform = GameObject.Find(platformName);
        // Make it invisible and not solid
        platform.gameObject.SetActive(false);
    }

    // When the player collides with the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger");
        if (other.CompareTag("Player"))
        {
            // Make the platform visible and solid
            platform.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
