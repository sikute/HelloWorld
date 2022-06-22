using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices
{


public class Mang2Chieu : MonoBehaviour
{
    float[,] secondArray;
    //float[,] secondArray = new float[2, 5];
    //float[,] secondArray = new float[,]
    //{
    //    {1.2f,1.3f },
    //    {2.1f, 2.2f },
    //    {3.5f, 7.6f }
    //};

    /*
    float[,] secondArray = 
        {
        {1.2f,1.3f },
        {2.1f, 2.2f },
        {3.5f, 7.6f }
        };
    */

    private void Start()
    {
        // secondArray = new float[2,5];
        secondArray = new float[,]
        {
           {1.2f,1.3f },
           {2.1f, 2.2f },
           {3.5f, 7.6f }
        };

        //for(int i =0; i< secondArray.GetLength(0); i++)
        //{
        //    for (int j = 0; j < secondArray.GetLength(1); j++)
        //    {
        //        Debug.Log(secondArray[i, j]);
        //    }
        //}

        //int row = 0;
        //int col = 0;
        //while(row < secondArray.GetLength(0))
        //{
        //    col = 0;
        //    while(col < secondArray.GetLength(1))
        //    {
        //        Debug.Log(secondArray[row, col]);
        //        col++;
        //    }
        //    row++;
        //}

        foreach (float temp in secondArray)
        {
            Debug.Log(temp);
        }


    }
}
}

