using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadMainScene : MonoBehaviour
{
    public void LoadManScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void LoadHack1Scene()
    {
        SceneManager.LoadScene("Asstroids");
    }
}
