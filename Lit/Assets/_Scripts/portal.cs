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
		if(Input.GetKeyDown(KeyCode.UpArrow) == true && teleport == true)
        {
            Debug.Log("LOL");
            player.position = portalOut.position;
            teleport = false;
        }
	}
    public void OnTriggerEnter2D(Collider2D vari)
    {
        if(vari.gameObject.tag == "Player")
        {
            teleport = true;
        }
    }
    public void OnTriggerExit2D(Collider2D vari)
    {
        if (vari.gameObject.tag == "Player")
        {
            teleport = false;
        }
    }
}
