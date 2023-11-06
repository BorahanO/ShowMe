using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMinigame : MonoBehaviour
{
    public int minigameIndex;

    public void OnMinigameButtonPressed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(minigameIndex);
    }
}
