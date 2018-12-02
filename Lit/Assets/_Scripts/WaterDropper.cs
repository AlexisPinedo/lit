using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropper : MonoBehaviour 
{

    public GameObject drop;
    public float droptime;
    // Update is called once per frame
     void Start()
    {
        InvokeRepeating("SpawnDrop", 1f, droptime);
    }
   void SpawnDrop()
    {
        Instantiate(drop);
        //drop.transform.position;
    }
   
}
