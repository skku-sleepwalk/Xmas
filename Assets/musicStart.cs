using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicStart : MonoBehaviour
{

    public GameObject musicPlayer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) ||
            Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // AudioSource 컴포넌트를 찾아서 음악 재생
            AudioSource audioSource = musicPlayer.GetComponent<AudioSource>();
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }

            // 이 스크립트가 부착된 게임 오브젝트를 파괴
            Destroy(gameObject);
        }
    }
}
