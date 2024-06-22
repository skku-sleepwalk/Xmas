using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterAction : MonoBehaviour
{
    public float speed = 5.0f; // 움직이는 속도를 조절할 수 있는 변수
    public Sprite upSprite;    // 위쪽 이동 스프라이트
    public Sprite downSprite;  // 아래쪽 이동 스프라이트
    public Sprite leftSprite;  // 왼쪽 이동 스프라이트
    public Sprite rightSprite;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); // 좌우 이동
        float moveVertical = Input.GetAxisRaw("Vertical"); // 상하 이동
        Vector2 movement = Vector2.zero;

        // 수평 입력이 있을 경우 수평 이동만 처리
        if (moveHorizontal != 0)
        {
            movement = new Vector2(moveHorizontal, 0);
            // 좌우 이동에 따라 스프라이트 변경
            spriteRenderer.sprite = moveHorizontal > 0 ? rightSprite : leftSprite;
        }
        // 수평 입력이 없을 경우 수직 이동만 처리
        else if (moveVertical != 0)
        {
            movement = new Vector2(0, moveVertical);
            // 상하 이동에 따라 스프라이트 변경
            spriteRenderer.sprite = moveVertical > 0 ? upSprite : downSprite;
        }
       

        // 수평 입력이 있을 경우 수평 이동만 처리
        if (moveHorizontal != 0)
        {
            movement = new Vector2(moveHorizontal, 0);
        }
        // 수평 입력이 없을 경우 수직 이동만 처리
        else if (moveVertical != 0)
        {
            movement = new Vector2(0, moveVertical);
        }

        // Rigidbody2D에 속도를 적용하여 실제 이동 처리
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}

