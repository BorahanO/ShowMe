using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(0, +speed * Time.deltaTime, 0);
        transform.position = newPosition;
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("Border"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (col.gameObject.tag == ("Enemy"))
        {
            SceneManager.LoadScene("LoseMinigame");
        }
    }
}