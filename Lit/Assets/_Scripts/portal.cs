using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {
    public Transform player;
    public Transform portalOut;
    bool teleport = false;
    void Start()
    {

    }
    void Update () {
		if((Input.GetKeyDown("up") || (Input.GetKeyDown("w"))) && teleport == true)
        {
            Debug.Log("LOL");
            player.position = portalOut.position;
            teleport = false;
        }
	}
    public void OnTriggerEnter2D(Collider2D vari)
    {
        if(vari.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Teleport setting true");
            teleport = true;
        }
    }
    public void OnTriggerExit2D(Collider2D vari)
    {
        if (vari.gameObject.tag == "Player")
        {
            //Debug.Log("Teleport setting false");
            teleport = false;
        }
    }
}
