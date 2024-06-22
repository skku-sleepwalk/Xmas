using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarMove : MonoBehaviour
{
    public float speed; // �̵� �ӵ�
    private int frameCount = 0; // ������ ī����
    private int direction = 1;  // �̵� ���� (1: ������, -1: ����)
    public static bool hitChecker;
    public static int HitNumber;
    public static bool IsAble;
    public static bool IsStarted;
    public float darkenAmount = 0.2f;  // ��ο����� ������ ������ �� �ִ� ����
    private Color originalColor;       // ���� ���� ���� ���� ����
    private Color darkenedColor;       // ���� ������ �������� ���� �� ��ο� ��
    private bool isOriginal = true;    // ���� ������ ���� �������� ����
    public Image image;
    private void Awake()
    {
        hitChecker = false;
        IsAble = true;
        IsStarted = false;
    }
    void Start()
    {
        // ������ ����Ʈ�� 60���� ����
        Application.targetFrameRate = 60;
            // Renderer ������Ʈ�� ������
        originalColor = image.color;  // ���� ���� ����
        darkenedColor = DarkenColor(originalColor);  // ���� ������ �������� ��ο� ���� ���
        UpdateColor();
    }
    

    // ���� ���¿� ���� ������ �����ϴ� �Լ�
    private void UpdateColor()
    {
        Color currentColor = isOriginal ? originalColor : darkenedColor;
        image.color = currentColor;
    }

    // ������ ��Ӱ� �����ϴ� �Լ�
    private Color DarkenColor(Color color)
    {
        return new Color(
            color.r ,
            color.g,
            color.b,
            color.a+0.5f
            );
    }
    public static IEnumerator StopBar(float delaySeconds)
    {
        
        IsAble = false;  // �ʱ⿡ false�� ����
        Debug.Log(IsAble);
            yield return new WaitForSeconds(delaySeconds);  // ������ �ð���ŭ ���
        IsAble = true;  // n�� �Ŀ� true�� ����
        Debug.Log(IsAble);
    }
   

    void Update()
    {
        if (IsAble && IsStarted)
        {
            transform.Translate(Vector3.right * direction * speed);

            // ������ ī��Ʈ ����
            frameCount++;
            isOriginal = true;
            UpdateColor();
        }
        else
        {
            isOriginal = false;
            UpdateColor();
        }
        // �� �����Ӹ��� ��ġ ������Ʈ
        
        HitNumber = frameCount / 30;
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

