using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D vari)
    {
        if (vari.gameObject.tag == "Player")
        {
            Debug.Log("Cheese has been found.");
            Mouse.incrementCheese();
            Destroy( gameObject );
        }
    }
}
