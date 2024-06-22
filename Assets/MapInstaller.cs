using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MapInstaller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wall;
    public GameObject brownWall;
    void Start()
    {
        for (int i = 2; i < 6; i++)Instantiate(wall, new Vector3(i, 3, 1), Quaternion.identity);
        for (int i = 5; i < 12; i++)Instantiate(wall, new Vector3(i, 2, 1), Quaternion.identity);
        for (int j = 4; j < 6; j++)Instantiate(wall, new Vector3(0, j, 1), Quaternion.identity);
        for (int i = 1; i < 10; i++)Instantiate(wall, new Vector3(i, 5, 1), Quaternion.identity);
            
        
        Instantiate(brownWall, new Vector3(6, 4, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(7, 4, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(8, 3, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(9, 3, 1), Quaternion.identity);
        for(int j = 3; j < 8; j++)Instantiate(wall, new Vector3(11, j, 1), Quaternion.identity);
        for (int j = 6; j < 10; j++) Instantiate(wall, new Vector3(9, j, 1), Quaternion.identity);
        for (int i = 10; i < 14; i++) Instantiate(wall, new Vector3(i, 9, 1), Quaternion.identity);
        for (int j = 2; j < 8; j++) Instantiate(brownWall, new Vector3(12, j, 1), Quaternion.identity);
        for (int j = 2; j < 9; j++) Instantiate(wall, new Vector3(13, j, 1), Quaternion.identity);
        for (int i = 13; i < 21; i++) Instantiate(wall, new Vector3(i, 2, 1), Quaternion.identity);
        for (int j = -3; j < 2; j++) Instantiate(wall, new Vector3(9, j, 1), Quaternion.identity);
        
        for (int i =10; i < 13; i++) Instantiate(wall, new Vector3(i, -3, 1), Quaternion.identity);
        for (int j = -2; j < 0; j++) Instantiate(wall, new Vector3(12, j, 1), Quaternion.identity);
        for (int i = 13; i < 23; i++) Instantiate(wall, new Vector3(i, -1, 1), Quaternion.identity);
         Instantiate(wall, new Vector3(22, 0, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(22, 1, 1), Quaternion.identity);
        for(int j=3;j<6;j++) Instantiate(wall, new Vector3(19, j, 1), Quaternion.identity);
        for (int i = 20; i < 23; i++) Instantiate(wall, new Vector3(i, 5, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(22, 4, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(21, 4, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(20, 4, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(21, 3, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(20, 3, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(22, 2, 1), Quaternion.identity);

    }

    // Update is called once per frame

}
