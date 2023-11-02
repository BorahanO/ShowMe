using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        transform.position = newPosition;

        moveWithMouse();
    }

    void moveWithMouse()
    {
        //slowly move to mouse position on x axis
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // move towards mouse with steady speed unless mouse is close to player on the x axis

        if(Mathf.Abs(mousePosition.x - transform.position.x) > 1f)
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(mousePosition.x, transform.position.y), speed * Time.deltaTime);

    }
}