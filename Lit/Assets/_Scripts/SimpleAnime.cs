using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnime : MonoBehaviour {

    // Use this for initialization
    [SerializeField] Vector3 pos;
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
        MoveToTest();
    }

    void MoveToTest()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", pos, "time", 5f, "easetype", iTween.EaseType.easeInOutSine, "looptype", iTween.LoopType.pingPong) );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }


    
}
