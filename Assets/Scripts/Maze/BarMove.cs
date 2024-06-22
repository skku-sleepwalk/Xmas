using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarMove : MonoBehaviour
{
    public float speed; // 이동 속도
    private int frameCount = 0; // 프레임 카운터
    private int direction = 1;  // 이동 방향 (1: 오른쪽, -1: 왼쪽)
    public static bool hitChecker;
    public static int HitNumber;
    public static bool IsAble;
    public static bool IsStarted;
    public float darkenAmount = 0.2f;  // 어두워지는 정도를 조절할 수 있는 변수
    private Color originalColor;       // 게임 시작 시의 원래 색상
    private Color darkenedColor;       // 원래 색상을 기준으로 조금 더 어두운 색
    private bool isOriginal = true;    // 현재 색상이 원래 색상인지 여부
    public Image image;
    private void Awake()
    {
        hitChecker = false;
        IsAble = true;
        IsStarted = false;
    }
    void Start()
    {
        // 프레임 레이트를 60으로 설정
        Application.targetFrameRate = 60;
            // Renderer 컴포넌트를 가져옴
        originalColor = image.color;  // 원래 색상 저장
        darkenedColor = DarkenColor(originalColor);  // 원래 색상을 기준으로 어두운 색상 계산
        UpdateColor();
    }
    

    // 현재 상태에 따라 색상을 적용하는 함수
    private void UpdateColor()
    {
        Color currentColor = isOriginal ? originalColor : darkenedColor;
        image.color = currentColor;
    }

    // 색상을 어둡게 조정하는 함수
    private Color DarkenColor(Color color)
    {
        return new Color(
            color.r ,
            color.g,
            color.b,
            color.a+0.5f
            );
    }
    public static IEnumerator StopBar(float delaySeconds)
    {
        
        IsAble = false;  // 초기에 false로 설정
        Debug.Log(IsAble);
            yield return new WaitForSeconds(delaySeconds);  // 지정된 시간만큼 대기
        IsAble = true;  // n초 후에 true로 변경
        Debug.Log(IsAble);
    }
   

    void Update()
    {
        if (IsAble && IsStarted)
        {
            transform.Translate(Vector3.right * direction * speed);

            // 프레임 카운트 증가
            frameCount++;
            isOriginal = true;
            UpdateColor();
        }
        else
        {
            isOriginal = false;
            UpdateColor();
        }
        // 매 프레임마다 위치 업데이트
        
        HitNumber = frameCount / 30;
        // 120 프레임마다 방향 전환
        if (frameCount == 120)
        {
            direction *= -1; // 방향 전환
            frameCount = 0;  // 프레임 카운터 초기화
        }
        if (11 <= frameCount % 30 && frameCount % 30 <= 18)
        {
            hitChecker = true;
        }
        else
        {
            hitChecker = false;
        }
    }

}

