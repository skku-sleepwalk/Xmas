using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStat : MonoBehaviour
{
    private static int hp;
    private static int maxHp;
    private static string playerName;
    private static int exp=0;
    private static int maxExp;
    private static int item1;
    private static int item2;
    private static int item3;
    public Image screenFadeImage;
    void FadeOutScreen()
    {
        screenFadeImage.color = new Color(0, 0, 0, 0.5f);  // 반투명 검은색으로 설정
    }
    public static int Item1
    {
        get => item1;
        set
        {
            item1 = value;
        }
    }
    public static int Item2
    {
        get => item2;
        set
        {
            item2 = value;
        }
    }
    public static int Item3
    {
        get => item3;
        set
        {
            item3 = value;
        }
    }
    public static int Hp{
        get => hp;
        set
        {
            hp = value;
        }
    }
    public static int MaxHp
    {
        get => maxHp;
        set
        {
            maxHp = value;
        }
    }
    public static string PlayerName
    {
        get => playerName;
        set
        {
            playerName = value;
        }
    }

    public static int Exp
    {
        get => exp;
        set
        {
            exp += value;//+=임에 유의
        }
    }
    public static int MaxExp
    {
        get => maxExp;
        set
        {
            maxExp = value;
        }
    }
    private void Start()
    {
        Hp = 3;
    }
    private void Update()
    {
        if (hp < 0)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Color.red;
            screenFadeImage.color = new Color(0, 0, 0, 0.5f);
        }
    }



}
