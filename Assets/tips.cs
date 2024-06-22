using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tips : MonoBehaviour
{
    public GameObject tip;
    private Image sprite;
    public GameObject inst;
    public GameObject canv;
    // Start is called before the first frame update
    void Start()
    {
        inst = Instantiate(tip, canv.transform);
        sprite = inst.GetComponent<Image>();
    }

    // Update is called once per frame
// Inspector에서 할당
    private bool isTransparent = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            isTransparent = !isTransparent; // 투명 상태 토글
            Color newColor = sprite.color;
            newColor.a = isTransparent ? 1f : 0f; // 알파 값을 조절
            sprite.color = newColor;
        }
    }
}
