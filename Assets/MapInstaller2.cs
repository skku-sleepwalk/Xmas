using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MapInstaller2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wall;
    public GameObject brownWall;
    void Start()
    {
          //for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i, 3, 1), Quaternion.identity);
          //for (int j = 0; j < 6; j++)Instantiate(wall, new Vector3(1, j, 1), Quaternion.identity);
          //Instantiate(wall, new Vector3(7, 4, 1), Quaternion.identity);

          Instantiate(wall, new Vector3(0, 1, 0), Quaternion.identity); Instantiate(wall, new Vector3(1, 0, 0), Quaternion.identity); Instantiate(wall, new Vector3(-1, 0, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(0, -9, 0), Quaternion.identity);Instantiate(wall, new Vector3(1, -8, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-3, -9, 0), Quaternion.identity);Instantiate(wall, new Vector3(-4, -8, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-2, -5, 0), Quaternion.identity);Instantiate(wall, new Vector3(-3, -4, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-9, -5, 0), Quaternion.identity);Instantiate(wall, new Vector3(-8, -6, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-8, 12, 0), Quaternion.identity);Instantiate(wall, new Vector3(-4, 10, 0), Quaternion.identity); Instantiate (wall,new Vector3(-12, 10, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-4, 2, 0), Quaternion.identity);Instantiate(wall, new Vector3(-5, 3, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-3, 4, 0), Quaternion.identity);Instantiate(wall, new Vector3(-7, 4, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-7, 1, 0), Quaternion.identity); Instantiate(wall, new Vector3(1, 4, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(4, 2, 0), Quaternion.identity); Instantiate(wall, new Vector3(10, -2, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-2, 16, 0), Quaternion.identity); Instantiate(wall, new Vector3(-3, 27, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-1, 27, 0), Quaternion.identity);Instantiate(wall, new Vector3(5, 21, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(6, 21, 0), Quaternion.identity);Instantiate(wall, new Vector3(11, 10, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(16, 11, 0), Quaternion.identity); Instantiate(wall, new Vector3(13, 14, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(12, 20, 0), Quaternion.identity); Instantiate(wall, new Vector3(14, 20, 0), Quaternion.identity);
          Instantiate(wall, new Vector3(-6, 0, 0), Quaternion.identity); Instantiate(wall, new Vector3(10, 0, 0), Quaternion.identity);

          for (int j = 0; j < 6; j++)Instantiate(wall, new Vector3(-3, j+11, 1), Quaternion.identity);
          for (int j = 0; j < 4; j++)Instantiate(wall, new Vector3(-4, j+13, 1), Quaternion.identity);
          for (int j = 0; j < 4; j++)Instantiate(wall, new Vector3(-5, j+13, 1), Quaternion.identity);

          for (int j = 0; j < 8; j++)Instantiate(wall, new Vector3(-13, j+11, 1), Quaternion.identity);
          for (int j = 0; j < 6; j++)Instantiate(wall, new Vector3(-12, j+13, 1), Quaternion.identity);
          for (int j = 0; j < 6; j++)Instantiate(wall, new Vector3(-11, j+13, 1), Quaternion.identity);

          for (int j = 0; j < 3; j++)Instantiate(wall, new Vector3(-10, j+17, 1), Quaternion.identity);
          for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i-8, 18, 1), Quaternion.identity);
          for (int i = 0; i < 7; i++)Instantiate(wall, new Vector3(i-9, 20, 1), Quaternion.identity);

          for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i-6, 22, 1), Quaternion.identity);
          for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i-6, 21, 1), Quaternion.identity);
          for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i+3, 23, 1), Quaternion.identity);

          for (int j = 0; j < 8; j++)Instantiate(wall, new Vector3(-6, j+23, 1), Quaternion.identity);
          for (int i = 0; i < 2; i++)Instantiate(wall, new Vector3(i-5, 31, 1), Quaternion.identity);
          for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i-3, 30, 1), Quaternion.identity);
          for (int j = 0; j < 9; j++)Instantiate(wall, new Vector3(-1, j+17, 1), Quaternion.identity);
          for (int j = 0; j < 8; j++)Instantiate(wall, new Vector3(2, j+22, 1), Quaternion.identity);
          for (int j = 0; j < 9; j++)Instantiate(wall, new Vector3(0, j+20, 1), Quaternion.identity);
          for (int j = 0; j < 9; j++)Instantiate(wall, new Vector3(7, j+13, 1), Quaternion.identity);
          
          for (int j = 0; j < 9; j++)Instantiate(wall, new Vector3(9, j+15, 1), Quaternion.identity);
          for (int j = 0; j < 8; j++)Instantiate(wall, new Vector3(10, j+15, 1), Quaternion.identity);
          for (int j = 0; j < 7; j++)Instantiate(wall, new Vector3(11, j+15, 1), Quaternion.identity);
          for (int j = 0; j < 7; j++)Instantiate(wall, new Vector3(15, j+14, 1), Quaternion.identity);
          for (int j = 0; j < 10; j++)Instantiate(wall, new Vector3(17, j+1, 1), Quaternion.identity);

          for (int j = 0; j < 7; j++)Instantiate(wall, new Vector3(17, j+3, 1), Quaternion.identity);
          for (int j = 0; j < 4; j++)Instantiate(wall, new Vector3(14, j+3, 1), Quaternion.identity);
          for (int j = 0; j < 4; j++)Instantiate(wall, new Vector3(13, j+3, 1), Quaternion.identity);
          for (int j = 0; j < 4; j++)Instantiate(wall, new Vector3(11, j+1, 1), Quaternion.identity);
          for (int j = 0; j < 2; j++)Instantiate(wall, new Vector3(3, j+5, 1), Quaternion.identity);

          for (int j = 0; j < 2; j++)Instantiate(wall, new Vector3(-3, j+18, 1), Quaternion.identity);
          for (int j = 0; j < 5; j++)Instantiate(wall, new Vector3(-4, j+24, 1), Quaternion.identity);
          for (int j = 0; j < 2; j++)Instantiate(wall, new Vector3(4, j+20, 1), Quaternion.identity);

          for (int i = 0; i < 6; i++)Instantiate(wall, new Vector3(i+5, 4, 1), Quaternion.identity);
          for (int i = 0; i < 9; i++)Instantiate(wall, new Vector3(i+4, 6, 1), Quaternion.identity);
          for (int i = 0; i < 5; i++)Instantiate(wall, new Vector3(i+12, 1, 1), Quaternion.identity);

          for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i+8, 13, 1), Quaternion.identity);
          for (int i = 0; i < 3; i++)Instantiate(wall, new Vector3(i+3, 23, 1), Quaternion.identity);
          for (int i = 0; i < 4; i++)Instantiate(wall, new Vector3(i+1, 20, 1), Quaternion.identity);
          for (int i = 0; i < 3; i++)Instantiate(wall, new Vector3(i+12, 9, 1), Quaternion.identity);
          for (int i = 0; i < 3; i++)Instantiate(wall, new Vector3(i-6, 5, 1), Quaternion.identity);

          for (int i = 0; i < 3; i++)Instantiate(wall, new Vector3(i-3, 28, 1), Quaternion.identity);
          for (int i = 0; i < 2; i++)Instantiate(wall, new Vector3(i-3, 25, 1), Quaternion.identity);

          for (int j = 0; j < 7; j++)Instantiate(wall, new Vector3(15, j+3, 1), Quaternion.identity);

    }

    // Update is called once per frame

}
