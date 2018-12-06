using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour {
    static int cheese = 0;
    public float newPlaceX;
    public Animator successAnimation;
    public GameObject player;
    public GameObject mouse;

    public void Awake()
    {
        cheese = 0;
    }

    public static int incrementCheese()
    {
        cheese++;
        
        Debug.Log("Cheese added" + cheese);
        return cheese;
    }
    void OnTriggerEnter2D(Collider2D vari)
    {
        if (vari.gameObject.tag == "Player" && cheese == 5)
        {
            StartCoroutine(Wait());
            //float start = transform.position.x;
            //iTween.MoveTo(this.gameObject, iTween.Hash("x", start + newPlaceX, "time", 5f, "isLocal", true, "easetype", iTween.EaseType.easeInOutSine));
            Debug.Log(" Sufficient Cheese");
            cheese = 0;
        }
        else if (vari.gameObject.tag == "Player" && cheese != 5)
        {
            Debug.Log("Keep Trying fam");

        }
    }

    IEnumerator Wait()
    {
        //this.GetComponent<SpriteRenderer>().enabled = false;
        player.transform.position = new Vector3(11.59f, 3.861256f, 0f);
        player.gameObject.SetActive(false);
        successAnimation.SetBool("Success", true);
        yield return new WaitForSeconds(4f);
        successAnimation.SetBool("Success", false);
        //this.GetComponent<SpriteRenderer>().enabled = true;
        mouse.transform.position = new Vector3(7.85f, 4.68f, 0f);
        player.gameObject.SetActive(true);

    }

}

