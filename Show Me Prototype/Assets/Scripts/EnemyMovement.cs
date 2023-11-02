using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject loseScreen;

    void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
        transform.position = newPosition;
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}