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
// Inspector���� �Ҵ�
    private bool isTransparent = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            isTransparent = !isTransparent; // ���� ���� ���
            Color newColor = sprite.color;
            newColor.a = isTransparent ? 1f : 0f; // ���� ���� ����
            sprite.color = newColor;
        }
    }
}
