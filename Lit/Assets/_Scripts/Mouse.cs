using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
    static int cheese = 0;
    public float newPlaceX;
    public static void incrementCheese()
    {
        cheese++;
        Debug.Log("Cheese added" + cheese);
    }
    void OnTriggerEnter2D(Collider2D vari)
    {
        if (vari.gameObject.tag == "Player" && cheese == 5)
        {
            float start = transform.position.x;
            iTween.MoveTo(this.gameObject, iTween.Hash("x", start + newPlaceX, "time", 5f, "isLocal", true, "easetype", iTween.EaseType.easeInOutSine));
            Debug.Log(" Sufficient Cheese");
            cheese = 0;
        }
        else if (vari.gameObject.tag == "Player" && cheese != 5)
        {
            Debug.Log("Keep Trying fam");

        }
    }

}
