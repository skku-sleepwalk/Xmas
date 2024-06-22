using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sign : MonoBehaviour
{
    public string sceneName;  // 불러올 씬의 이름
    public float detectionRadius = 1f;  // 플레이어 감지 반경
    public LayerMask playerLayer;  // 플레이어 레이어 마스크

    // Update is called once per frame
    void Update()
    {
        // A키를 누르고 플레이어가 근처에 있으면 씬 로드
        if (Input.GetKeyDown(KeyCode.A) && IsPlayerNear())
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // 플레이어가 근처에 있는지 검사
    private bool IsPlayerNear()
    {
        Collider2D player = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);
        return player != null;
    }
}
