using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterGenerator : MonoBehaviour
{
    public GameObject floor;
    public GameObject floor1;
    public GameObject wall;
    public GameObject door;
    GameObject instance;
    void Start()
    {
        bool isOne = true;
        for (int i = -3; i < 4; i++) {
            for (int j = -3; j < 4; j++)
            {
                instance = Instantiate(isOne?floor1:floor);
                instance.transform.position = new Vector3(i, j, 0);
                isOne = !isOne;
            }
        }
        for (int i = 5; i < 8; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                instance = Instantiate(isOne ? floor1 : floor);
                instance.transform.position = new Vector3(i, j, 0);
                isOne = !isOne;
            }
        }
        for (int i = -7; i < -4; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                instance = Instantiate(isOne ? floor1 : floor);
                instance.transform.position = new Vector3(i, j, 0);
                isOne = !isOne;
            }
        }
        for (int i = -1; i < 2; i++)
        {
            for (int j = 5; j < 8; j++)
            {
                instance = Instantiate(isOne ? floor1 : floor);
                instance.transform.position = new Vector3(i, j, 0);
                isOne = !isOne;
            }
        }
        for (int i = -1; i < 2; i++)
        {
            for (int j = -7; j < -4; j++)
            {
                instance = Instantiate(isOne ? floor1 : floor);
                instance.transform.position = new Vector3(i, j, 0);
                isOne = !isOne;
            }
        }
        for (int i=-4;i<5;i++)
        {
            if (i != 0)
                instance = Instantiate(wall);
            else
                instance = Instantiate(door);
            instance.transform.position = new Vector3(4, i, 0);
            
        }
        for (int i = -4; i < 5; i++)
        {
            if (i != 0)
                instance = Instantiate(wall);
            else
                instance = Instantiate(door);
            instance.transform.position = new Vector3(-4, i, 0);

        }
        for (int i = -4; i < 5; i++)
        {
            if (i != 0)
                instance = Instantiate(wall);
            else
                instance = Instantiate(door);
            instance.transform.position = new Vector3(i, 4, 0);

        }
        for (int i = -4; i < 5; i++)
        {
            if (i != 0)
                instance = Instantiate(wall);
            else
                instance = Instantiate(door);
            instance.transform.position = new Vector3(i, -4, 0);

        }
    }


    
}
