using UnityEngine;

public class InstantlyMovement : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 input;

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(5, 0, 0);
        //transform.position = new Vector3(100, 0, 0)*Time.deltaTime;
        //Debug.Log(transform.position + "_" + Time.deltaTime);

        //transform.position += new Vector3(1f, 0, 0);
        //transform.position += new Vector3(1f,0,0)*Time.deltaTime;

        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // Support analogue 8-way movement that's even in all directions
        input = Vector3.ClampMagnitude(input, 1);
        transform.position += input * speed * Time.deltaTime;
    }
}
