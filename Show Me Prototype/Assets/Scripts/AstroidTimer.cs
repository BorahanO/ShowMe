using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroidTimer : MonoBehaviour
{
    private bool hasFunctionBeenCalled = false;

    void Start()
    {
        Invoke("LoadMailScene", 120.0f); // 120 seconds (2 minutes)
    }

    void LoadMailScene()
    {
        if (!hasFunctionBeenCalled)
        {
            SceneManager.LoadScene("SampleScene");
            hasFunctionBeenCalled = true; // Ensure the function is called only once
        }
    }
}