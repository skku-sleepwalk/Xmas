using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainCharacterMaze : MonoBehaviour
{
    public float moveSpeed = 5f;
    private int moveFlag = 0;
    //private bool delaying = false;
    private Rigidbody2D rb;
    RaycastHit2D hit;
    void Start()
    {
        // Rigidbody 컴포넌트 가져오기
        rb = GetComponent<Rigidbody2D>();
    }
    
        
        //if (!delaying)Invoke("wallStop", 0.1f);
        //delaying = true;
    
    //oncoll
    private void getMove()
    {
        if (moveFlag == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (BarMove.hitChecker) moveFlag = 1;
                else
                {
                    PlayerStat.Hp -= 1;
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (BarMove.hitChecker) moveFlag = 2;
                else
                {
                    PlayerStat.Hp -= 1;
                }
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (BarMove.hitChecker) moveFlag = 3;
                else
                {
                    PlayerStat.Hp -= 1;
                }

            }
            if (Input.GetKeyDown(KeyCode.DownArrow) )
            {
                if (BarMove.hitChecker) moveFlag = 4;
                else
                {
                    PlayerStat.Hp -= 1;
                }
            }
        }
       
    }
    private void move() { 
        if(moveFlag == 1)
        {
            rb.velocity = Vector2.right * moveSpeed;
            //rb.AddForce(Vector3.right * moveSpeed);
            //transform.Translate(Vector3.right * moveSpeed*Time.deltaTime);
        }
        else if (moveFlag == 2)
        {
            rb.velocity = Vector2.left * moveSpeed;
           //rb.AddForce(Vector3.left * moveSpeed);
         //   transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (moveFlag == 3)
        {
            rb.velocity = Vector2.up * moveSpeed;
            //rb.AddForce(Vector3.up * moveSpeed);

            //transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else if (moveFlag == 4)
        {
            rb.velocity = Vector2.down * moveSpeed;
            //rb.AddForce(Vector3.down * moveSpeed);
           // transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }


    }
    private void wallStop() {
        RaycastHit2D hit;
        switch (moveFlag)
        {
            case 1:

                 hit = Physics2D.Raycast(transform.position, Vector2.right, 0.5f, 1<<6);
                //Debug.DrawRay(transform.position, Vector2.right* 0.6f, new Color(0, 1, 0));
                //Debug.Log(hit.collider);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    //if (rb.velocity != Vector2.zero) transform.Translate(Vector2.right * 0.1f);
                    rb.velocity = Vector2.zero;
                }
                
                break;
            case 2:
                 hit = Physics2D.Raycast(transform.position, Vector2.left, 0.5f, 1 << 6);
                //Debug.DrawRay(transform.position, Vector2.left * 0.6f, new Color(0, 1, 0));
                //Debug.Log(hit.collider);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    //if (rb.velocity != Vector2.zero) transform.Translate(Vector2.left * 0.1f);
                    rb.velocity = Vector2.zero;
                }
                break;
            case 3:
                 hit = Physics2D.Raycast(transform.position, Vector2.up, 0.5f, 1 << 6);
               // Debug.DrawRay(transform.position, Vector2.up * 0.6f, new Color(0, 1, 0));
                //Debug.Log(hit.collider);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                   // if (rb.velocity != Vector2.zero) transform.Translate(Vector2.up * 0.1f);
                    rb.velocity = Vector2.zero;
                }
                break;
            case 4:
                 hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, 1 << 6);
               // Debug.DrawRay(transform.position, Vector2.down * 0.6f, new Color(0, 1, 0));
                //Debug.Log(hit.collider);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    
                   // if(rb.velocity!=Vector2.zero)transform.Translate(Vector2.down * 0.1f);
                    rb.velocity = Vector2.zero;
                }
                break;
            default:
                break;

        }
 
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //if (rb.velocity == Vector2.zero) transform.position = new Vector2((float)Math.Round(transform.position.x), (float)Math.Round(transform.position.y));
        getMove();
        if (moveFlag !=0) wallStop();
        move();
        
       // Debug.Log("flag=" + moveFlag);

       // Debug.Log("vel=" + rb.velocity);
        
    }
    
}
