using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doctor : MonoBehaviour
{
    public Rigidbody2D _rb;
    public int moveSpeed;

    public int jumpSpeed;
    public Animator _anim;

    Vector2 myScale;
    float myScaleX;
    bool isJumping;

    void Start()
    {
        myScale = transform.localScale;
        myScaleX = myScale.x;
    }

    void Update()
    {
        if (GetComponent<Health>().dead)
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
            return;
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            myScale.x = -myScaleX;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            myScale.x = myScaleX;
        }

        transform.localScale = myScale;

        _rb.velocity = new Vector2
        (Input.GetAxisRaw("Horizontal") * moveSpeed,
        _rb.velocity.y);

        // if (Input.GetButtonDown("Jump"))
        if (Input.GetKeyDown(KeyCode.W) && isJumping == false)
        {
            isJumping = true;
            _rb.velocity = new Vector2
            (_rb.velocity.x, jumpSpeed);

            _anim.SetBool("isJump", true);

        }

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            _anim.SetBool("isRun", true);
        }
        else
        {
            _anim.SetBool("isRun", false);
        }

        if (Input.GetKeyDown(KeyCode.F) && isAttacking == false)
        {
            isAttacking = true;

        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            _anim.SetBool("isJump", false);
            isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Collectable"))

        {
            print("we have collected an item");

            Destroy(collision.gameObject);
        }


    }





}

