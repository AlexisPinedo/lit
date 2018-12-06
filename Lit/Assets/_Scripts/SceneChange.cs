using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    // Use this for initialization
    public Animator animator;
    private int levelLoad;
	
	// Update is called once per frame
	void Update () 
    {
		
	}
    public void FadetoLevel(int LevelIntex)
    {
       levelLoad = LevelIntex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelLoad);
    }
}
