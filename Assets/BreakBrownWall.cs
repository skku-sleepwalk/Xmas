using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class BreakBrownWall : MonoBehaviour
{
    Collider2D[] hits;
    int r = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            r = 0;
            if (BarMove.hitChecker)
            {
                hits = Physics2D.OverlapCircleAll(transform.position, 1.6f,1<<9);

                while (true)
                {
                    //Debug.Log(hits[0]);
                    if (hits!=null&&hits[r] != null && hits[r].transform.tag == "brownWall")
                    {
                        Destroy(hits[r].gameObject);
                    }
                    else
                    {
                        break;
                    }
                    r++;
                }
                
                
            }
            else
            {
                PlayerStat.Hp -= 1;
            }
        }
    }
}
