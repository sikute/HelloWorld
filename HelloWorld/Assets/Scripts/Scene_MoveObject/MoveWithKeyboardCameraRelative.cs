using UnityEngine;

public class MoveWithKeyboardCameraRelative : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        Transform cameraTransform = Camera.main.transform;
        Vector3 cameraPosition = new Vector3(cameraTransform.position.x, transform.position.y, cameraTransform.position.z);
        Vector3 direction = (transform.position - cameraPosition).normalized;
        //Debug.Log(direction);
        Vector3 verticalMovement = direction * Input.GetAxis("Vertical");
        Vector3 horizontalMovement = cameraTransform.right * Input.GetAxis("Horizontal");
        Vector3 movement = Vector3.ClampMagnitude(verticalMovement + horizontalMovement, 1);
        transform.Translate(speed * Time.deltaTime * movement, Space.World);
        //Debug.Log(transform.position +"_"+ cameraPosition);
    }
}
