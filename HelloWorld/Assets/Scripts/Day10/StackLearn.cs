using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day10
{
    public class StackLearn : MonoBehaviour
    {
        Stack stack;
        Stack stack2;
        ArrayList arrayList;
        private void Start()
        {
            stack = new Stack();
            stack.Push("udev");
            stack.Push(1);
            stack.Push(1.4f);
            Debug.Log(stack.Peek());

            foreach (var temp in stack)
            {
                Debug.Log(temp);
            }
        }
    }
}