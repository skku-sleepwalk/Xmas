using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManger : MonoBehaviour
{
    public static int itemStatus = 1;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1)||Input.GetKeyDown(KeyCode.Alpha1))
        {
            itemStatus = 1;
            Debug.Log(itemStatus);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            itemStatus = 2;
            Debug.Log(itemStatus);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            itemStatus = 3;
            Debug.Log(itemStatus);
        }
      //  else if (Input.GetKeyDown(KeyCode.Z))
        //{
            //USEITEM
        //}
    }
}
