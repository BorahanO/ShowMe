using UnityEngine;
using UnityEngine.SceneManagement;

public class Boder : MonoBehaviour
{
    int health;
    int defaultHealth = 3;

    public GameObject[] hearts;

    void Start()
    {
        health = defaultHealth;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Enemy"))
        {
            health--;
        }

        if (col.gameObject.tag == ("Enemy")&& health == 0)
        {
            SceneManager.LoadScene("LoseMinigame");
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
