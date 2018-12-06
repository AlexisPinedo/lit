using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropper : MonoBehaviour 
{

    public Rigidbody2D drop;
    public float x, y;
   // public float droptime;
    // Update is called once per frame
     void Start()
    {
        InvokeRepeating("SpawnDrop", .5f, .5f);
    }
   void SpawnDrop()
    {
        Rigidbody2D water= Instantiate(drop);
        // water.position = gameObject.GetComponent<WaterDropper>();
        drop.transform.position = new Vector2(this.transform.position.x, this.transform.position.y);
    }
   
}
