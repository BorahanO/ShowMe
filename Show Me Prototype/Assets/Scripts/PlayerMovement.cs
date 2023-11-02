using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    int health;
    int defaultHealth = 3;

    public GameObject[] hearts;

    void Start()
    {
        health = defaultHealth;
    }
    void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(0, +speed * Time.deltaTime, 0);
        transform.position = newPosition;
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Enemy"))
        {
            health--;
        }
        if (col.gameObject.tag == ("Enemy") && health == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (col.gameObject.tag == ("End"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        UpdateImages();
    }

    private void UpdateImages()
    {
        //match health with appearing hearts images
        for (int i = 0; i < hearts.Length; i++)
        {
            if (health > hearts.Length)
            {
                health = hearts.Length;
            }

            if (i < health)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }
    }

}