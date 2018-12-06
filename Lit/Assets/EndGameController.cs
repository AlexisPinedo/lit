using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EndGameController : MonoBehaviour {

    public GameObject shadowParticleEffect;
    public GameObject player;
    public BoxCollider2D endbox;
    public CinemachineVirtualCamera mainCamera;

    private void Awake()
    {
        shadowParticleEffect.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = new Vector3(4.69f, -1.85f, 0f);
        mainCamera.m_Lens.OrthographicSize = 10;
    }
}
