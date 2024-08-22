using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovePhysics : MonoBehaviour
{
    public Rigidbody rb;
    public float forces = 5f;
    public float forcesImpulse = 5f;
    public bool isJump;
    Vector3 startPosition;
    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isJump)
        {
            Jump();
        }
        else if(Input.GetMouseButtonDown(1) && !isJump)
        {
            JumpWithImpulse();
        }
        if(rb.velocity.y == 0)
        {
            isJump = false;
        }
    }
    void Jump()
    {
        isJump = true;
        rb.AddForce(Vector3.up * forces);
    }
    void JumpWithImpulse()
    {
        isJump = true;
        rb.AddForce(Vector3.up * forcesImpulse, ForceMode.Impulse);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Plane"))
    //    {
    //        isJump = false;
    //    }
    //}
}
