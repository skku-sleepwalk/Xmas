using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorA : MonoBehaviour
{
    public Sprite openDoorSprite;  // 문이 열린 상태의 이미지
    public Sprite closedDoorSprite;  // 문이 닫힌 상태의 이미지
    public float detectionRadius = 2.0f;  // 플레이어 감지 반경
    public LayerMask playerLayer;  // 플레이어 레이어

    private bool isOpen = false;  // 문이 열려 있는지 여부
    private SpriteRenderer spriteRenderer;
    private Collider2D doorCollider;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        doorCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && PlayerIsNear())
        {
            ToggleDoor();
        }
    }

    // 문의 상태를 변경하는 함수
    private void ToggleDoor()
    {
        isOpen = !isOpen;  // 문 상태 토글
        spriteRenderer.sprite = isOpen ? openDoorSprite : closedDoorSprite;
        doorCollider.isTrigger = isOpen;  // 문이 열렸다면 Collider를 Trigger로 설정
    }

    // 플레이어가 문 근처에 있는지 판단하는 함수
    private bool PlayerIsNear()
    {
        // Physics2D.OverlapCircle을 사용하여 주변에 플레이어가 있는지 확인
        Collider2D player = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);
        return player != null;  // 플레이어가 감지되면 true 반환
    }

    void OnDrawGizmosSelected()
    {
        // 에디터에서 감지 범위를 시각화
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
