using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameSceneLoad : MonoBehaviour {

    public Animator sceneAnimation;
    // Use this for initialization

    bool trig=false;
    // Update is called once per frame
    void Update () 
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
         
        sceneAnimation.SetTrigger("FadeOut");
        trig = true;
    }
}
