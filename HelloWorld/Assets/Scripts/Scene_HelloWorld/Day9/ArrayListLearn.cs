using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day9
{
public class ArrayListLearn : MonoBehaviour
{
        private ArrayList arrayList;
        private ArrayList arrayList2;
        private void Start()
        {
            arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(12);
            //arrayList.Add("udev");

            arrayList2 = new ArrayList();
            arrayList2.Add(2);
            arrayList2.Add(9);
            //arrayList2.Add("udev");

            //Debug.Log(arrayList.Count);
            //Debug.Log(arrayList.Capacity);

            arrayList.AddRange(arrayList2);
            //arrayList.Clear();

            //Debug.Log(arrayList.Contains(9.1f));

            //var arrCopy = arrayList.GetRange(2,3);
            //Debug.Log(arrCopy.Count);
            //Debug.Log(arrayList.IndexOf("udev"));

            //arrayList.Insert(3,"100");
            arrayList.Remove("udev");
            arrayList.Reverse();

            var arr = arrayList.ToArray();
            var arrClone = (ArrayList)arrayList.Clone();

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    var arrItem = arrayList[i];
            //    Debug.Log(arrayList[i]);
            //}
            arrayList.Sort();

            foreach (var temp in arrayList)
            {
                Debug.Log(temp);
            }
        }

    }

   
}
