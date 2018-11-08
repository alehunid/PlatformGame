using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheDoor : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if this gameObject detects the player 
        //gameObject will apply the following effect if player contains key
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerState script = collision.gameObject.GetComponent<PlayerState>(); //checks player script
            if (script.key_found == true) //checks to see if key has been found
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
