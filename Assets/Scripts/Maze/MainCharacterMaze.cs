using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMaze : MonoBehaviour
{
    public float moveSpeed = 5f;
    private int moveFlag = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        wallStop();
    }
    private void getMove()
    {
        if (moveFlag == 0)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                moveFlag = 1;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveFlag = 2;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveFlag = 3;

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                moveFlag = 4;
            }
        }
       
    }
    private void move() { 
        if(moveFlag == 1)
        {
            transform.Translate(Vector3.right * moveSpeed*Time.deltaTime);
        }
        else if (moveFlag == 2)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (moveFlag == 3)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else if (moveFlag == 4)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }


    }
    private void wallStop() { 
        if(moveFlag != 0) {
            moveFlag = 0;
            //닿았는지 체크//캐릭터크기는 맵 크기에 딱 맞게 가도록 하자
            //moveFlag = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {
        getMove();
        move();
        
    }
    
}
