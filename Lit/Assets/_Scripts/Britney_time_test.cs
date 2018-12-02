using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Britney_time_test : MonoBehaviour
{
   

    [SerializeField]
    public float time;
    [SerializeField]
    private int healPoints;
    // Use this for initialization
    //  public bool held = Input.GetKey(KeyCode.Escape);

    void Start()
    {
        Debug.Log("Begin");
    }
   
    // Update is called once per frame 
    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.collider.tag == "Danger" )
       {
            Debug.Log("Hits danger.");
            healPoints--;
       }
        if (collision.collider.tag == "Drop")
        {
            healPoints--;
        }
    }
    void Update()
    {
        if (time > 0.0f)
        {
            time -= Time.deltaTime;
        }
        
        if (healPoints <= 0.0f || time <= 0.0f)
        {
            Debug.Log("Made it into the else if");
            time = 0;
            healPoints = 0;
            GameOver();
        }
       
    }
    void GameOver()
    {
        Debug.Log("Dead :P");
        SceneManager.LoadScene("GameOverMenu");

        //new scene implementeds
    }
   

}
