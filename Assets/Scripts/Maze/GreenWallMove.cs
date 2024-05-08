using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenWallMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    private int moveFlag = 0;
    private Rigidbody2D rb;
    RaycastHit2D hit;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void getMove(int dir)
    {
        moveFlag = dir;
        //Debug.Log("moving");
    }
    private void move()
    {
        Debug.Log("moving");
        if (moveFlag == 1)
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
    private void wallStop()
    {
        RaycastHit2D hit;
        switch (moveFlag)
        {
            case 1:

                hit = Physics2D.Raycast(transform.position, Vector2.right, 0.51f, 1 << 6);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                }

                break;
            case 2:

                hit = Physics2D.Raycast(transform.position, Vector2.left, 0.51f, 1 << 6);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                }
                break;
            case 3:
                hit = Physics2D.Raycast(transform.position, Vector2.up, 0.51f, 1 << 6);

                if (hit.collider != null)
                {
                    moveFlag = 0;
                    rb.velocity = Vector2.zero;
                }
                break;
            case 4:
                hit = Physics2D.Raycast(transform.position, Vector2.down, 0.51f, 1 << 6);

                if (hit.collider != null)
                {
                    moveFlag = 0;
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
        if (moveFlag != 0) wallStop();
        if (moveFlag != 0) move();

        // Debug.Log("flag=" + moveFlag);

        // Debug.Log("vel=" + rb.velocity);

    }
}
