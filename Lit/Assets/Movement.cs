using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    bool onGround = true;
    public float speed = 5f;
    public float jump = 5f;
    public Rigidbody2D rf;
    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(hInput * speed * Time.deltaTime, 0, 0);
        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            rf.AddForce(new Vector3(0, jump, 0), ForceMode2D.Impulse);
            onGround = false;
        }
    }
    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }
}
