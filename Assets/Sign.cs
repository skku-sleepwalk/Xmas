using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sign : MonoBehaviour
{
    public string sceneName;  // �ҷ��� ���� �̸�
    public float detectionRadius = 1f;  // �÷��̾� ���� �ݰ�
    public LayerMask playerLayer;  // �÷��̾� ���̾� ����ũ

    // Update is called once per frame
    void Update()
    {
        // AŰ�� ������ �÷��̾ ��ó�� ������ �� �ε�
        if (Input.GetKeyDown(KeyCode.A) && IsPlayerNear())
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // �÷��̾ ��ó�� �ִ��� �˻�
    private bool IsPlayerNear()
    {
        Collider2D player = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);
        return player != null;
    }
}
