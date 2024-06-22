using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetExperience : MonoBehaviour
{
    public int magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStat.Exp = magnitude;
        Debug.Log("exp is " + PlayerStat.Exp);
        Destroy(gameObject);
    }
}
