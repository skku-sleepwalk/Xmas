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
            // AudioSource ������Ʈ�� ã�Ƽ� ���� ���
            AudioSource audioSource = musicPlayer.GetComponent<AudioSource>();
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }

            // �� ��ũ��Ʈ�� ������ ���� ������Ʈ�� �ı�
            Destroy(gameObject);
        }
    }
}
