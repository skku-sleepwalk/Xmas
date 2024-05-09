using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    RaycastHit2D hit;
    public static bool usingItem;
    private int dir;
    private void Awake()
    {
        usingItem = false;
        dir = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !usingItem)
        {
            usingItem = true;
        }
        else if (usingItem && !Input.GetKeyDown(KeyCode.Z))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) dir = 0;
            if (Input.GetKeyDown(KeyCode.RightArrow)) dir = 1;
            if (Input.GetKeyDown(KeyCode.DownArrow)) dir = 2;
            if (Input.GetKeyDown(KeyCode.LeftArrow)) dir = 3;
            Debug.Log("now dir is" + dir);
        }
        else if (usingItem&&Input.GetKeyDown(KeyCode.Z))
        {
            switch (ItemManger.itemStatus)
            {
                case 1:
                    switch (dir)
                    {
                        case 0:
                            hit = Physics2D.Raycast(transform.position, Vector2.up, 4.5f, 1 << 9);
                            break;
                        case 1:
                            hit = Physics2D.Raycast(transform.position, Vector2.right, 4.5f, 1 << 9);
                            break;
                        case 2:
                            hit = Physics2D.Raycast(transform.position, Vector2.down, 4.5f, 1 << 9);
                            break;
                        case 3:
                            hit = Physics2D.Raycast(transform.position, Vector2.left, 4.5f, 1 << 9);
                            break;
                        default:
                            break;

                    }
                    if (hit.collider != null && hit.transform.tag == "brownWall")
                    {
                        Destroy(hit.collider.gameObject);
                    }
                    break;
                case 2:
                    switch (dir)
                    {
                        case 0:
                            hit = Physics2D.Raycast(transform.position, Vector2.up, 4.5f, 1 << 7);
                            break;
                        case 1:
                            hit = Physics2D.Raycast(transform.position, Vector2.right, 4.5f, 1 << 7);
                            break;
                        case 2:
                            hit = Physics2D.Raycast(transform.position, Vector2.down, 4.5f, 1 << 7);
                            break;
                        case 3:
                            hit = Physics2D.Raycast(transform.position, Vector2.left, 4.5f, 1 << 7);
                            break;
                        default:
                            break;

                    }
                    if(hit.collider==null)hit= Physics2D.Raycast(transform.position, Vector2.left, 4.5f, 1 << 6);
                    //Debug.Log(hit.collider);
                    //Debug.DrawLine(gameObject.transform.position, hit.point, Color.red);
                    if (hit.collider != null && hit.transform.tag == "greenWall")
                    {
                        hit.transform.GetComponent<GreenWallMove>().getMove((dir+2)%4);
                    }
                    break;
                case 3:
                    switch (dir)
                    {
                        case 0:
                            hit = Physics2D.Raycast(transform.position, Vector2.up, 0.7f, 1 << 7);
                            break;
                        case 1:
                            hit = Physics2D.Raycast(transform.position, Vector2.right, 0.7f, 1 << 7);
                            break;
                        case 2:
                            hit = Physics2D.Raycast(transform.position, Vector2.down, 0.7f, 1 << 7);
                            break;
                        case 3:
                            hit = Physics2D.Raycast(transform.position, Vector2.left, 0.7f, 1 << 7);
                            break;
                        default:
                            break;

                    }
                    Debug.Log(hit.transform.tag);
                    if (hit.collider != null && hit.transform.tag == "greenWall")
                    {
                        hit.transform.GetComponent<GreenWallMove>().getMove(dir);
                    }
                    break;
                default:
                    break;
            }
            usingItem = false;
            Debug.Log("usingItem is"+usingItem);
        }
    }
}
