using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    RaycastHit2D hit;
  
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (ItemManger.itemStatus)
            {
                case 1:

                case 2:

                case 3:
                    hit = Physics2D.Raycast(transform.position, Vector2.right, 0.55f, 1 << 7);
                    Debug.Log(hit.transform.tag);
                    if (hit.collider != null && hit.transform.tag == "greenWall")
                    {
                        hit.transform.GetComponent<GreenWallMove>().getMove(1);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
