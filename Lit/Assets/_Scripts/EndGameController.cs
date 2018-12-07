using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour {

    public GameObject shadowParticleEffect;
    public GameObject player;
    public BoxCollider2D endbox;
    public CinemachineVirtualCamera mainCamera;
    float step = 0f;
    public float speed = 5f;
    private Vector3 cameraStartingLocation;
    private Vector3 cameraEndLocation = new Vector3(-.91f, 0.355f, -10f);
    Movement script;
    bool endGame = false;
    public Animator playerAnimation;
    public Animator sceneAnimation;
    private IEnumerator coroutine;
    public float waitTime = 3;


    private void Awake()
    {
        shadowParticleEffect.SetActive(false);
    }

    private void Start()
    {
        script = player.GetComponent<Movement>();
    }
    private void FixedUpdate()
    {
        step = speed * Time.deltaTime;
        cameraStartingLocation = mainCamera.transform.position;
    }

    //added; can you make code enter this line? not ever entering the below method.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("entered collisionand should fade");
        if (collision.collider.tag == "Player")
        {
            Debug.Log("entered if statement");
            sceneAnimation.SetTrigger("FadeOut");
            endGame = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Wait());
        player.transform.position = new Vector3(4.69f, -1.85f, 0f);
        script.enabled = false;
        mainCamera.m_Lens.OrthographicSize = 8;
        mainCamera.Follow = null;
        playerAnimation.SetFloat("Speed", 0); 
        Debug.Log("Starting coroutine");
       
        //mainCamera.transform.position = Vector3.MoveTowards(cameraStartingLocation, cameraEndLocation, step)
    }
   
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
       //should not switch scenes unless fadeout happens
        Debug.Log("Waited");
        if(endGame==true)
        {
            SceneManager.LoadScene("GameOverMenuWin");
        }

    }
}
