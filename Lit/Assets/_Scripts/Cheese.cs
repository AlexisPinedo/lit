using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cheese : MonoBehaviour {
    public AudioSource ping;
    public Text cheeseCount;


    private void Start()
    {
        //ping = this.GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D vari)
    {
        
        if (vari.gameObject.tag == "Player")
        {
            ping.Play();
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log("Cheese has been found.");
            int cheese = Mouse.incrementCheese();
            cheeseCount.text = "CHEESE: " + cheese + " / 5";
            Destroy(gameObject);
            //this.gameObject.SetActive(false);
        }
    }
}
