using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBar : MonoBehaviour
{
    // Start is called before the first frame update
    public float second;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision != null&&collision.tag=="Player")
        {
           
            
            StartCoroutine(BarMove.StopBar(second));
            Destroy(gameObject);
        }
        
    }
}
