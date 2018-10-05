using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Britney_time_test : MonoBehaviour {
   
    [SerializeField] 
    private float time;
    [SerializeField] 
    private int healPoints;
	// Use this for initialization
	 void Start () 
    {
        Debug.Log("Begin");
	}
	
	// Update is called once per frame
	void Update() 
    {
        if(time>= 0.0f)
        {
            time -= Time.deltaTime;
        }
        else if (time <= 0.0f)
        {
            GameOver();
        }
		
	}
    void GameOver()
    {
        Debug.Log("Dead :P");

        // new scene implemented
    }
}
