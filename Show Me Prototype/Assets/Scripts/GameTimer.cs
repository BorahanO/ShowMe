using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimr : MonoBehaviour
{
    [SerializeField] private float countdownTime; // 2 minutes in seconds
    [SerializeField] private TMP_Text textComponent;
    private float timer;

    void Start()
    {
        timer = countdownTime;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateText();
        }
        else
        {
            timer = 0;
            UpdateText();
            // Handle timer completion or any desired action here
        }
    }

    void UpdateText()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        textComponent.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}