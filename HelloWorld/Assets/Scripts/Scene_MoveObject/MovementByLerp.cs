using System.Collections;
using UnityEngine;

public class MovementByLerp : MonoBehaviour
{
    public float duration = 1f;
    public float heightOpen = 4.5f;
    bool doorOpen;
    Vector3 closePosition;
    float timeElapsed;
    
    void Start()
    {
        closePosition = transform.position;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("OperateDoor");
            OperateDoor();
        }
    }

    public void OperateDoor()
    {
        StopAllCoroutines();
        if (!doorOpen)
        {
            Vector3 openPosition = closePosition + Vector3.up * heightOpen;
            StartCoroutine(MoveDoor(openPosition));
        }
        else
        {
            StartCoroutine(MoveDoor(closePosition));
        }
        doorOpen = !doorOpen;
    }
    IEnumerator MoveDoor(Vector3 targetPosition)
    {
        timeElapsed = 0;
        Vector3 startPosition = transform.position;

        while(timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
