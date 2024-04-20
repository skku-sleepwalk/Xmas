using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManger : MonoBehaviour
{
    static int itemStatus = 1;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            itemStatus = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            itemStatus = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            itemStatus = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            //USEITEM
        }
    }
}
