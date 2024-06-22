using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MapInstaller1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wall;
    public GameObject brownWall;
    void Start()
    {
        for (int i = 0; i < 14; i++)Instantiate(wall, new Vector3(i - 13, 1, 1), Quaternion.identity);
        for (int i = 0; i < 16; i++)Instantiate(wall, new Vector3(i - 15, -1, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(1, 0, 1), Quaternion.identity);
        for (int j = 0; j < 14; j++)Instantiate(wall, new Vector3 (-14, j+1, 1), Quaternion.identity);
        for (int j = 0; j < 16; j++)Instantiate(wall, new Vector3 (-16, j, 1), Quaternion.identity);
        for (int i = 0; i < 8; i++)Instantiate(wall, new Vector3(i - 15, 16, 1), Quaternion.identity);
        for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i - 13, 14, 1), Quaternion.identity);
        for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i - 5, 16, 1), Quaternion.identity);
        for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i - 6, 14, 1), Quaternion.identity);
        for (int j = 0; j < 14; j++)Instantiate(wall, new Vector3 (1, j+2, 1), Quaternion.identity);
        for (int j = 0; j < 12; j++)Instantiate(wall, new Vector3 (-1, j+3, 1), Quaternion.identity);       
        for (int i = 0; i < 12; i++)Instantiate(wall, new Vector3(i - 12, 3, 1), Quaternion.identity);        
        for (int j = 0; j < 10; j++)Instantiate(wall, new Vector3 (-12, j+3, 1), Quaternion.identity); 
        for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i - 11, 12, 1), Quaternion.identity);
        for (int i = 0; i < 3; i++)Instantiate(wall, new Vector3(i - 6, 12, 1), Quaternion.identity);
        for (int j = 0; j < 8; j++)Instantiate(wall, new Vector3 (-3, j+5, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-5, 5, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-9, 6, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-6, 8, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-8, 9, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-11, 11, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-5, 11, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-4, 10, 1), Quaternion.identity);

        for (int j = 0; j < 8; j++)Instantiate(wall, new Vector3 (-6, j+17, 1), Quaternion.identity);
        for (int j = 0; j < 9; j++)Instantiate(wall, new Vector3 (-8, j+17, 1), Quaternion.identity);
        for (int i = 0; i < 3; i++)Instantiate(wall, new Vector3(i - 7, 26, 1), Quaternion.identity);
        for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i - 3, 26, 1), Quaternion.identity);
        for (int j = 0; j < 14; j++)Instantiate(wall, new Vector3 (1, j+17, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-3, 17, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-3, 21, 1), Quaternion.identity); Instantiate(wall, new Vector3(-2, 21, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-5, 21, 1), Quaternion.identity);

        for (int j = 0; j < 4; j++)Instantiate(wall, new Vector3 (-3, j+27, 1), Quaternion.identity);
        for (int i = 0; i < 5; i++)Instantiate(wall, new Vector3(i - 8, 31, 1), Quaternion.identity);
        for (int i = 0; i < 10; i++)Instantiate(wall, new Vector3(i - 19, 31, 1), Quaternion.identity);
        for (int j = 0; j < 7; j++)Instantiate(wall, new Vector3 (-20, j+24, 1), Quaternion.identity);
        for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i - 19, 23, 1), Quaternion.identity);
 
        for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i - 13, 23, 1), Quaternion.identity);
        for (int j = 0; j < 3; j++)Instantiate(wall, new Vector3 (-15, j+20, 1), Quaternion.identity);
        for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i - 14, 19, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-10, 20, 1), Quaternion.identity); 
        Instantiate(wall, new Vector3(-9, 21, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-10, 24, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-10, 27, 1), Quaternion.identity); Instantiate(wall, new Vector3(-15, 27, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(-11, 28, 1), Quaternion.identity); Instantiate(wall, new Vector3(-14, 28, 1), Quaternion.identity);

        Instantiate(wall, new Vector3(-10, 37, 1), Quaternion.identity); Instantiate(wall, new Vector3(-9, 38, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(7, 37, 1), Quaternion.identity); Instantiate(wall, new Vector3(6, 38, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(5, 6, 1), Quaternion.identity); Instantiate(wall, new Vector3(6, 5, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(10, 5, 1), Quaternion.identity); Instantiate(wall, new Vector3(11, 6, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(9, 21, 1), Quaternion.identity); Instantiate(wall, new Vector3(10, 22, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(13, 22, 1), Quaternion.identity); Instantiate(wall, new Vector3(14, 21, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(13, 13, 1), Quaternion.identity); Instantiate(wall, new Vector3(12, 14, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(16, 13, 1), Quaternion.identity); Instantiate(wall, new Vector3(17, 14, 1), Quaternion.identity);Instantiate(wall, new Vector3(18, 15, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(18, 15, 1), Quaternion.identity); Instantiate(wall, new Vector3(15, 18, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(19, 14, 1), Quaternion.identity);Instantiate(wall, new Vector3(16, 19, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(20, 18, 1), Quaternion.identity);Instantiate(wall, new Vector3(19, 19, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(22, 16, 1), Quaternion.identity);Instantiate(wall, new Vector3(23, 15, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(22, 11, 1), Quaternion.identity);Instantiate(wall, new Vector3(21, 12, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(29, 11, 1), Quaternion.identity);Instantiate(wall, new Vector3(30, 12, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(28, 19, 1), Quaternion.identity);Instantiate(wall, new Vector3(29, 20, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(60, 18, 1), Quaternion.identity);Instantiate(wall, new Vector3(61, 19, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(5, 31, 1), Quaternion.identity);Instantiate(wall, new Vector3(7, 31, 1), Quaternion.identity);Instantiate(wall, new Vector3(5, 32, 1), Quaternion.identity);Instantiate(wall, new Vector3(7, 32, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(5, 20, 1), Quaternion.identity);Instantiate(wall, new Vector3(5, 21, 1), Quaternion.identity);Instantiate(wall, new Vector3(7, 20, 1), Quaternion.identity);Instantiate(wall, new Vector3(7, 21, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(5, 15, 1), Quaternion.identity);Instantiate(wall, new Vector3(5, 16, 1), Quaternion.identity);Instantiate(wall, new Vector3(7, 15, 1), Quaternion.identity);Instantiate(wall, new Vector3(7, 16, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(9, 11, 1), Quaternion.identity);Instantiate(wall, new Vector3(9, 12, 1), Quaternion.identity);Instantiate(wall, new Vector3(11, 11, 1), Quaternion.identity);Instantiate(wall, new Vector3(11, 12, 1), Quaternion.identity);
        Instantiate(wall, new Vector3(9, 15, 1), Quaternion.identity);Instantiate(wall, new Vector3(9, 16, 1), Quaternion.identity);Instantiate(wall, new Vector3(11, 15, 1), Quaternion.identity);Instantiate(wall, new Vector3(11, 16, 1), Quaternion.identity);


        Instantiate(brownWall, new Vector3(-2, 15, 1), Quaternion.identity); Instantiate(brownWall, new Vector3(-10, 15, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(-7, 17, 1), Quaternion.identity); Instantiate(brownWall, new Vector3(-8, 30, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(6, 31, 1), Quaternion.identity); Instantiate(brownWall, new Vector3(6, 20, 1), Quaternion.identity); Instantiate(brownWall, new Vector3(6, 15, 1), Quaternion.identity);
        Instantiate(brownWall, new Vector3(10, 15, 1), Quaternion.identity); Instantiate(brownWall, new Vector3(10, 11, 1), Quaternion.identity);
    }


    // Update is called once per frame

}
