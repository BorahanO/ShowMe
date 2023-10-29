using UnityEngine;
using UnityEngine.SceneManagement;

public class Boder : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("Enemy"))
        {
            SceneManager.LoadScene("LoseMinigame");
        }
    }
}
