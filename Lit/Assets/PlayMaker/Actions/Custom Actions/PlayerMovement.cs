using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript.Steps;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory("Custom Actions")]
    [Tooltip("Move The player with velocity")]

    public class PlayerMovement : FsmStateAction
    {
        [RequiredField]
        public GameObject player;

        private Rigidbody2D rb;

        [RequiredField]
        public float speed = 10f;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmBool isFacingUp;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmBool isFacingDown;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmBool isFacingLeft;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmBool isFacingRight;



        public override void Awake()
        {
            Fsm.HandleFixedUpdate = true;
            rb = player.GetComponent<Rigidbody2D>();
            isFacingDown.Value = true;
            isFacingUp.Value = false;
            isFacingLeft.Value = false;
            isFacingRight.Value = false;
            
        }

        public override void OnFixedUpdate()
        {
            Move();
        }


        private void Move()
        {
            //grab the value of controller value
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");
            //Debug.Log("move x is" + moveX);
            //Debug.Log("move y is" + moveY);

            //if statements to set the direction of the player
            if (moveX > 0)
            {
                isFacingUp.Value = false;
                isFacingDown.Value = false;
                isFacingLeft.Value = false;
                isFacingRight.Value = true;
                //Debug.Log("I am Facing Right");
            }
            else if(moveX < 0)
            {
                isFacingUp.Value = false;
                isFacingDown.Value = false;
                isFacingLeft.Value = true;
                isFacingRight.Value = false;
                //Debug.Log("I am Facing Left");
            }
            else if (moveY > 0)
            {
                isFacingUp.Value = true;
                isFacingDown.Value = false;
                isFacingLeft.Value = false;
                isFacingRight.Value = false;
                //Debug.Log("I am Facing Up");
            }
            else if (moveY < 0)
            {
                isFacingUp.Value = false;
                isFacingDown.Value = true;
                isFacingLeft.Value = false;
                isFacingRight.Value = false;
                //Debug.Log("I am Facing Down");
            }

            //velocity based movement of the player
            Vector2 movement = new Vector2(moveX, moveY);
            rb.velocity = movement * speed;
        }




    }

}
