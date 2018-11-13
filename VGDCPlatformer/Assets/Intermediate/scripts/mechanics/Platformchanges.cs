using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public string stateplatform;
    public float disappeartime;
    int count = 0;
    SpriteRenderer platformspriterenderer;
    BoxCollider2D platformcollider;

    void Start()
    {
        platformspriterenderer = GetComponent<SpriteRenderer>();
        platformcollider = GetComponent<BoxCollider2D>();
    }
    
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //set the player as a child to the platform gaemObject
        //this allows movement of the player with moving platforms
        if (collision.gameObject.CompareTag("Player"))
        { 

            collision.collider.transform.SetParent(transform);
        }
        //checks how the platform should break and makes sure it isn't activated multiple times
        //delete is to have the time completely remove the platform and transparent makes the platform opaque then come back after a time
        if ((stateplatform == "delete" || stateplatform == "transparent") && !IsInvoking("disappearing"))
        {
            InvokeRepeating("disappearing", 1, 1);
            if (stateplatform == "delete")
            {
                StartCoroutine("buhbye", collision);
            }
            else if (stateplatform == "transparent")
            {
                StartCoroutine("goobye", collision);
            }
            //animate the platform to shake
            //decides whether to delete platform or let the platform return after a while
            
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        //removes the player from being a child of this platform gameObject
        //once player is not on the platform.
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null);
        }
    }

    //deletes the platfrom and moves the player from being a child of the platform
    IEnumerator buhbye(Collision2D collision)
    {
        //makes the whole coroutine wait for indicated seconds
        yield return new WaitForSeconds(disappeartime);
        //sets player's parent to null so it doesn't get deleted with platform
        collision.collider.transform.SetParent(null);
        //deletes the platform 1 second after
        Destroy(gameObject, 1f);
    }
    //makes the platform return after a while
    IEnumerator goobye(Collision2D collision)
    {
        //make temp alpha to keep colors and change the alpha
        Color c = platformspriterenderer.color;
        //alpha value
        c.a = .3f;
        //makes the whole coroutine wait for indicated seconds
        yield return new WaitForSeconds(disappeartime);
        //sets player's parent to null so platform doesn't affect the player too
        collision.collider.transform.SetParent(null);
        //changes platform alpha then disables the platform collider
        platformspriterenderer.color = c;
        //makes the platform uncollidable
        platformcollider.enabled = !platformcollider.enabled;
        //waits for respawn
        yield return new WaitForSeconds(disappeartime);
        //changes temp alpha to completely visible, then changes the platform alpha and reenables collider
        c.a = 1f;
        platformspriterenderer.color = c;
        platformcollider.enabled = !platformcollider.enabled;
    }

    void disappearing()
    {
        //counter to prevent multiple activations of the platforms
        Debug.Log(count);
        if (count < 10)
        {
            count++;
        }
        if (count == 10)
        {
            count = 0;
            Debug.Log("done");
            CancelInvoke();
        }
    }
}
