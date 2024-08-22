using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace SIRO.Practices.Day10
{ 
    public class LinQTest : MonoBehaviour
    {
        List<int> listA = new List<int>();
        List<int> listB = new List<int>();

        private void Start()
        {
            listA.Add(2);
            listA.Add(1);
            listA.Add(4);
            listA.Add(8);
            listA.Add(7);
            listA.Add(8);
            listA.Add(1);
            listA.Add(5);

            listB.Add(9);
            listB.Add(1);
            listB.Add(4);
            listB.Add(7);
            listB.Add(10);
            listB.Add(2);

            //var result = listA.Distinct().ToArray();
            //var result = listA.Except(listB);
            //var result = listA.Intersect(listB);
            //var result = listA.Union(listB);
            //var result = listA.Where(r => r > 2 && r < 6).ToArray();
            //var result = listA.Take(4);
            //var result = listA.Where(r => r <= 5).Take(4).ToArray();
            //var result = listA.Where(r => r <= 5).ToArray();
            var result = listA.Intersect(listB).Where(udev => udev ==7).ToArray();



            foreach (var item in result)
            {
                Debug.Log(item);
            }
        }

    }
}
