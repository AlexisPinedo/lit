using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndControllerScreenFade : MonoBehaviour {

    public Animator sceneAnimation;
    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D collision)
    {
        sceneAnimation.SetTrigger("FadeOut");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
