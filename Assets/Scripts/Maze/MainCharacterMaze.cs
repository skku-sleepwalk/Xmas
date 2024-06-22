using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainCharacterMaze : MonoBehaviour
{
    public AudioClip missSound;
    public AudioClip hitSound0;
    public AudioClip hitSound1;
    public AudioClip hitSound2;
    public AudioClip hitSound3;
    private void Miss()
    {
        if (BarMove.IsStarted)
        {
            PlayerStat.Hp -= 1;
            AudioManager.playSound(missSound);
        }
        
    }
    private void HitSound(int number)
    {
        switch (number)
        {
            case 0:
                AudioManager.playSound(hitSound0);

                break;
            case 1:
                AudioManager.playSound(hitSound1);

                break;
            case 2:
                AudioManager.playSound(hitSound2);
                break;
            case 3:
                AudioManager.playSound(hitSound3);
                break;
            default:
                break;
        }
       
    }
    public float moveSpeed = 5f;
    private int moveFlag = 0;
    private Rigidbody2D rb;
    RaycastHit2D hit;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void getMove()
    {
        if (moveFlag == 0&&!UseItem.usingItem)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                
                if (BarMove.hitChecker)
                {
                    moveFlag = 1;
                    HitSound(BarMove.HitNumber);
                }
                else
                {
                    Miss();
                }
                BarMove.IsStarted = true;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                
                if (BarMove.hitChecker)
                {
                    moveFlag = 2;
                    HitSound(BarMove.HitNumber);

                }
                else
                {
                    Miss();
                }
                BarMove.IsStarted = true;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                
                if (BarMove.hitChecker)
                {
                    moveFlag = 3;
                    HitSound(BarMove.HitNumber);

                }
                else
                {
                    Miss();
                }
                    BarMove.IsStarted = true;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) )
            {
                
                if (BarMove.hitChecker)
                {
                    moveFlag = 4;
                    HitSound(BarMove.HitNumber);

                }

                else
                {
                    Miss();
                }
                BarMove.IsStarted = true;
            }
        }
       
    }
    private void move() { 
        if(moveFlag == 1)
        {
            rb.velocity = Vector2.right * moveSpeed;
        }
        else if (moveFlag == 2)
        {
            rb.velocity = Vector2.left * moveSpeed;
        }
        else if (moveFlag == 3)
        {
            rb.velocity = Vector2.up * moveSpeed;
        }
        else if (moveFlag == 4)
        {
            rb.velocity = Vector2.down * moveSpeed;
        }


    }
    public Vector3 RoundVector3(Vector3 originalVector)
    {
        return new Vector3(
            Mathf.Round(originalVector.x),
            Mathf.Round(originalVector.y),
            Mathf.Round(originalVector.z)
        );
    }

    private void wallStop() {
        RaycastHit2D hit;
        switch (moveFlag)
        {
            case 1:

                 hit = Physics2D.Raycast(transform.position, Vector2.right, 0.51f, 1<<6);
                if(hit.collider==null) hit = Physics2D.Raycast(transform.position, Vector2.right, 0.61f, 1 << 7);
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.right, 0.51f, 1 << 9);
                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                    transform.position= RoundVector3(transform.position);
                }
                
                break;
            case 2:

                 hit = Physics2D.Raycast(transform.position, Vector2.left, 0.51f, 1 << 6);
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.left, 0.61f, 1 << 7);
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.left, 0.51f, 1 << 9);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                    transform.position = RoundVector3(transform.position);
                }
                break;
            case 3:
                 hit = Physics2D.Raycast(transform.position, Vector2.up, 0.51f, 1 << 6);
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.up, 0.61f, 1 << 7);
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.up, 0.51f, 1 << 9);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                    transform.position = RoundVector3(transform.position);
                }
                break;
            case 4:
                 hit = Physics2D.Raycast(transform.position, Vector2.down, 0.51f, 1 << 6 );
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.down, 0.61f, 1 << 7);
                if (hit.collider == null) hit = Physics2D.Raycast(transform.position, Vector2.down, 0.51f, 1 << 9);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                    transform.position = RoundVector3(transform.position);
                }
                break;
            default:
                break;

        }
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "goal") Debug.Log("END");
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
