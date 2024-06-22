using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterAction : MonoBehaviour
{
    public float speed = 5.0f; // �����̴� �ӵ��� ������ �� �ִ� ����

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); // �¿� �̵�
        float moveVertical = Input.GetAxisRaw("Vertical"); // ���� �̵�

        Vector2 movement = Vector2.zero;

        // ���� �Է��� ���� ��� ���� �̵��� ó��
        if (moveHorizontal != 0)
        {
            movement = new Vector2(moveHorizontal, 0);
        }
        // ���� �Է��� ���� ��� ���� �̵��� ó��
        else if (moveVertical != 0)
        {
            movement = new Vector2(0, moveVertical);
        }

        // Rigidbody2D�� �ӵ��� �����Ͽ� ���� �̵� ó��
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}

