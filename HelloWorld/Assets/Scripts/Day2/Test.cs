using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        int a = 0;
        ChangeA(ref a);
    }

    void ChangeA(ref int value)
    {
        value++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
