using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelateMovement : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 input;
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

       // Cause compounded effect, where turning the object throws off its forward vector, due to the Translate function which, by default,
       // applies movement relate to the object's position and orientation.
       // transform.Translate(speed * Time.deltaTime * transform.forward,Space.World);


        //transform.Translate(speed * Time.deltaTime * Vector3.back);

        transform.Translate(speed * Time.deltaTime * input);
    }
}

