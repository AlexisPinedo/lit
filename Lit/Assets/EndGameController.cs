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
    private IEnumerator coroutine;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = new Vector3(4.69f, -1.85f, 0f);
        script.enabled = false;
        mainCamera.m_Lens.OrthographicSize = 8;
        mainCamera.Follow = null;
        playerAnimation.SetFloat("Speed", 0);
        Debug.Log("Starting coroutine");
        //mainCamera.transform.position = Vector3.MoveTowards(cameraStartingLocation, cameraEndLocation, step);
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Waited");
        SceneManager.LoadScene("GameOverMenuWin");
    }
}
