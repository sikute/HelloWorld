using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position,speed*Time.deltaTime);
    }
}
