using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float time;
   

 
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            PlayerStat.Hp = -1;
        }
    }
}
