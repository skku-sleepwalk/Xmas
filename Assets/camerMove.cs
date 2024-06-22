using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerMove : MonoBehaviour
{
    public Transform target;  // ī�޶� ���� ���, �� �÷��̾��� Transform
    public float smoothing = 5f;  // ī�޶� �������� �ε巯�� ����

    private Vector3 offset;  // �ʱ� ī�޶�� ��� ������ �Ÿ�

    void Start()
    {
        // ���� ���� �� ī�޶�� ��� ������ �ʱ� �Ÿ� ���
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // ����� ���� ��ġ�� �������� ���Ͽ� ī�޶��� ��ǥ ��ġ�� ���
        Vector3 targetCamPos = target.position + offset;

        // Lerp �Լ��� ����Ͽ� ���� ī�޶� ��ġ���� ��ǥ ��ġ���� �ε巴�� �̵�
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
