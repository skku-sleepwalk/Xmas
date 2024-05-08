using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    public float speed; // �̵� �ӵ�
    private int frameCount = 0; // ������ ī����
    private int direction = 1;  // �̵� ���� (1: ������, -1: ����)
    public static bool hitChecker;
    private void Awake()
    {
        hitChecker = false;
    }
    void Start()
    {
        // ������ ����Ʈ�� 60���� ����
        Application.targetFrameRate = 60;
    }
   

    void Update()
    {
        // �� �����Ӹ��� ��ġ ������Ʈ
        transform.Translate(Vector3.right * direction * speed);

        // ������ ī��Ʈ ����
        frameCount++;

        // 120 �����Ӹ��� ���� ��ȯ
        if (frameCount == 120)
        {
            direction *= -1; // ���� ��ȯ
            frameCount = 0;  // ������ ī���� �ʱ�ȭ
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

