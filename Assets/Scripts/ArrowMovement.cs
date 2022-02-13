using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float speed;
    private float horizontalMove;
    private bool moveRight;
    private bool moveLeft;
    private Rigidbody2D rb;

    private bool countdownTime;

    private float boostTimer;
    private bool boosting;

    public float jumpSpeed = 7.0f;
    private float currentJumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveLeft = false;
        moveRight = false;

        boostTimer = 0;
        boosting = false;

        currentJumpSpeed = jumpSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        
    }

    

    public void pointerDownLeft()
    {
        moveLeft = true;
    }

    public void pointerUpLeft()
    {
        moveLeft = false;
    }

    public void pointerDownRight()
    {
        moveRight = true;
    }

    public void pointerUpRight()
    {
        moveRight = false;
    }

    public void pointerstraight()
    {
        //
    }

    public void pointerBack()
    {
        //
    }

    void Movement()
    {/*
        if(countdownTime)
        {
            if (moveLeft)
            {
                horizontalMove = -speed;
            }
            else if (moveRight)
            {
                horizontalMove = speed;
            }
            else
            {
                horizontalMove = 0;
            }
        }
        else
        {
            //
        }*/

        if (moveLeft)
        {
            horizontalMove = -speed;
        }
        else if (moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }

        if (boosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 3)
            {
                //speed = 10;
                boostTimer = 2;
                boosting = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "speedBoost")
        {
            boosting = true;
            speed = 10;
            Destroy(other.gameObject);
        }
    } 

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch (hit.gameObject.tag)
        {
            case "JumpPad":
                jumpSpeed = 25f;
                break;
            case "Ground": 
                jumpSpeed = currentJumpSpeed;
                break;
        }
    }
}
