using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    bool onGround = true;
    public float speed = 5f;
    public float jump = 5f;
    public Rigidbody2D rf;

    public Animator playerAnimator;

    public SpriteRenderer playerSpriteRenderer;
    
    // Update is called once per frame
    void Update()
    {
        
        float hInput = Input.GetAxis("Horizontal");
        
        float playersMovementX = hInput * speed * Time.deltaTime;
        
        transform.position = transform.position + new Vector3(playersMovementX, 0, 0);

        if (hInput < 0)
            playerSpriteRenderer.flipX = true;
        if (hInput > 0)
            playerSpriteRenderer.flipX = false;
        
        playerAnimator.SetFloat("Speed", Mathf.Abs(playersMovementX));
        /*if (Input.GetButtonDown("Jump") && onGround == true)
        {
            rf.AddForce(new Vector3(0, jump, 0), ForceMode2D.Impulse);
            onGround = false;
        }*/
    }
    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }
}
