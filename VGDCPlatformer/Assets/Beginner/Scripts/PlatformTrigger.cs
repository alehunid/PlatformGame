using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{

    private GameObject platform;

    // Use this for initialization
    void Start()
    {
        // Find the platform GameObject
        platform = GameObject.Find("Platform");
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
