using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerMove : MonoBehaviour
{
    public Transform target;  // 카메라가 따라갈 대상, 즉 플레이어의 Transform
    public float smoothing = 5f;  // 카메라 움직임의 부드러움 정도

    private Vector3 offset;  // 초기 카메라와 대상 사이의 거리

    void Start()
    {
        // 게임 시작 시 카메라와 대상 사이의 초기 거리 계산
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // 대상의 현재 위치에 오프셋을 더하여 카메라의 목표 위치를 계산
        Vector3 targetCamPos = target.position + offset;

        // Lerp 함수를 사용하여 현재 카메라 위치에서 목표 위치까지 부드럽게 이동
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
