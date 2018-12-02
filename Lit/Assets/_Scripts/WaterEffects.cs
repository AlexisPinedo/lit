using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEffects : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Debug.Log("Hits ground.");
            Destroy(this);
        }
    }
}
