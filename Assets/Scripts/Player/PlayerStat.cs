using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    private static int hp;
    private static int maxHp;
    private static string playerName;
    private static int exp=0;
    private static int maxExp;

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



}
