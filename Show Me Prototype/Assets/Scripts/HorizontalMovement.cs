using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        transform.position = newPosition;
    }
}