using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices
{

    public class Mang1Chieu : MonoBehaviour
    {
        int[] scoreArray;
        //int[] scoreArray = new int[10];
        //int[] scoreArray = new int[] { 1, 2, 3 };
        //int[] scoreArray = {1,2,3,4 };

        private void Start()
        {
            //scoreArray = new int[10];
            scoreArray = new int[] { 1, 2, 3, 4, 5 };

            //Debug.Log(scoreArray[0]);
            //Debug.Log(scoreArray[1]);
            //Debug.Log(scoreArray[2]);

            //for(int i = 0; i < scoreArray.Length; i++)
            //{
            //    Debug.Log(scoreArray[i]);
            //}

            //int count = 0;
            //while(count < scoreArray.Length)
            //{
            //    Debug.Log(scoreArray[count]);
            //    count++;
            //}

            //for(int i = scoreArray.Length -1; i >= 0; i--)
            //{
            //    if (i > 0)
            //    {
            //        Debug.Log($"Phan tu lien truoc cua {scoreArray[i]} la {scoreArray[i - 1]}");
            //    }
            //    if(i < scoreArray.Length - 1)
            //    {
            //        Debug.Log($"Phan tu lien sau cua {scoreArray[i]} la {scoreArray[i + 1]}");
            //    }
            //}

            //for (int i = 0; i < scoreArray.Length; i++)
            //{
            //    scoreArray[i] = 9;
            //    Debug.Log(scoreArray[i]);
            //}

            foreach (var temp in scoreArray)
            {
                Debug.Log(temp);
            }
        }
    }
}
