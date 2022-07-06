using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day10
{ 
    public class GenericTest : MonoBehaviour
    {
        //float a, b;

        Queue queue;
        Queue<int> queueInt;

        private void Start()
        {
            //Swap<float>(ref a,ref b);
            //GenericDemo<float> genericDemo = new GenericDemo<float>();

            queue = new Queue();
            queue.Enqueue(1); 
            queue.Enqueue("udev");

            queueInt = new Queue<int>();
            queueInt.Enqueue(2);
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
    }
    }
    public class GenericDemo<T>
    {
        public T propertyDemo;
        public GenericDemo()
        {
            Debug.Log(propertyDemo.GetType());
        }
    }
}
