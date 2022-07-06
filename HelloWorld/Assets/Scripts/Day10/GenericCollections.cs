using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day10
{ 
    public class GenericCollections : MonoBehaviour
    {
        //List<float> scoreArr; 
        //List<float> scoreArr2;

        Dictionary<string, int> dicDemo;
        Dictionary<string, int> dicDemo2;
        int dicDemoValue;

        private void Start()
        {
            //scoreArr = new List<float>(scoreArr2);
            //scoreArr.AddRange(scoreArr2);
            //scoreArr.Add(1f);
            //scoreArr.Remove(1);
            //scoreArr.RemoveAt(1);

            dicDemo = new Dictionary<string, int>();
            dicDemo.Add("udev", 1);
            dicDemo.Add("hocsinh", 5);
            dicDemo.Add("giaovien", 3);

            Debug.Log(dicDemo["hocsinh"]);

            var keys = dicDemo.Keys;
            var values = dicDemo.Values;

            Debug.Log(dicDemo.TryGetValue("udev", out dicDemoValue));
        }

    }
}
