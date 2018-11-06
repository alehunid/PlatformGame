using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheDoor : MonoBehaviour {

    SpriteRenderer sprite_renderer;

    void Start()
    {
        sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if this gameObject detects the player 
        //gameObject will apply the following effect if player contains key
        if (collision.gameObject.CompareTag("Player"))
        {  
            PlayerPickUp script = collision.gameObject.GetComponent<PlayerPickUp>(); //checks player script
            if(script.key_found == true) //checks to see if key has been found
            {
                sprite_renderer.color = Color.red; //changes tree to red if key is found
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
