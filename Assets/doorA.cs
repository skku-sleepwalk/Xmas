using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorA : MonoBehaviour
{
    public Sprite openDoorSprite;  // ���� ���� ������ �̹���
    public Sprite closedDoorSprite;  // ���� ���� ������ �̹���
    public float detectionRadius = 2.0f;  // �÷��̾� ���� �ݰ�
    public LayerMask playerLayer;  // �÷��̾� ���̾�

    private bool isOpen = false;  // ���� ���� �ִ��� ����
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

    // ���� ���¸� �����ϴ� �Լ�
    private void ToggleDoor()
    {
        isOpen = !isOpen;  // �� ���� ���
        spriteRenderer.sprite = isOpen ? openDoorSprite : closedDoorSprite;
        doorCollider.isTrigger = isOpen;  // ���� ���ȴٸ� Collider�� Trigger�� ����
    }

    // �÷��̾ �� ��ó�� �ִ��� �Ǵ��ϴ� �Լ�
    private bool PlayerIsNear()
    {
        // Physics2D.OverlapCircle�� ����Ͽ� �ֺ��� �÷��̾ �ִ��� Ȯ��
        Collider2D player = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);
        return player != null;  // �÷��̾ �����Ǹ� true ��ȯ
    }

    void OnDrawGizmosSelected()
    {
        // �����Ϳ��� ���� ������ �ð�ȭ
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
