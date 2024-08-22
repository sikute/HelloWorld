using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day9
{

    public class HashTableLearn : MonoBehaviour
{
        private Hashtable hashtable;
        private Hashtable hashtable2;
        void Start()
        {
            hashtable = new Hashtable();
            hashtable.Add("udev", 10);
            hashtable.Add("siro", "ten cua siro");
            hashtable.Add("tung", 12f);

            //Debug.Log(hashtable["tung"]);
            var keys = hashtable.Keys;
            var values = hashtable.Values;

            //foreach (var key in keys)
            //{
            //    Debug.Log(key);
            //}

            //foreach (var value in values)
            //{
            //    Debug.Log(value);
            //}

            //foreach(var temp in hashtable)
            //{
            //    Debug.Log(temp.GetType());
            //}

            foreach (DictionaryEntry temp in hashtable)
            {
                Debug.Log(temp.Value);
            }

            hashtable.Add("hai", 4);

        }

    }
}
