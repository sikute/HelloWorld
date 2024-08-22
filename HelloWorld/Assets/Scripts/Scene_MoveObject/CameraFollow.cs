using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float camDistance = 5f;
    public float camHeight = 3f;
    public float smoothTime = 0.5f;
    Vector3 velocity;

    private void Update()
    {
        transform.LookAt(target);
        Vector3 offset = (Camera.main.transform.position - target.position).normalized * camDistance;

        Vector3 targetPosition = target.position + offset;
        targetPosition.y = camHeight;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
    }
}
