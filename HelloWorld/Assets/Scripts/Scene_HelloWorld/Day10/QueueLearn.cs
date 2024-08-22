using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day10
{ 
public class QueueLearn : MonoBehaviour
{
    Queue queue;
    Queue queue2;
    ArrayList arrayList;

    private void Start()
    {
        queue = new Queue();
        queue.Enqueue(12);
        queue.Enqueue(2.9f);
        queue.Enqueue("udev");
        Debug.Log(queue.Peek());

        foreach (var temp in queue)
        {
            Debug.Log(temp);
        }
    }
}
}
