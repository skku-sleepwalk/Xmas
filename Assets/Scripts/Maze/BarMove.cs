using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    public float speed; // 이동 속도
    private int frameCount = 0; // 프레임 카운터
    private int direction = 1;  // 이동 방향 (1: 오른쪽, -1: 왼쪽)
    public static bool hitChecker;
    private void Awake()
    {
        hitChecker = false;
    }
    void Start()
    {
        // 프레임 레이트를 60으로 설정
        Application.targetFrameRate = 60;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitChecker = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        hitChecker = false;
    }

    void Update()
    {
        // 매 프레임마다 위치 업데이트
        transform.Translate(Vector3.right * direction * speed);

        // 프레임 카운트 증가
        frameCount++;

        // 120 프레임마다 방향 전환
        if (frameCount == 120)
        {
            direction *= -1; // 방향 전환
            frameCount = 0;  // 프레임 카운터 초기화
        }
    }

}

