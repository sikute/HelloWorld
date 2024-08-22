using UnityEngine;

public class MoveTowardsSmooth : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    public float smoothTime = 0.5f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime,speed);
    }
}
