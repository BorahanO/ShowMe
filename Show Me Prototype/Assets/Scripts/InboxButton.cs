using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InboxButton : MonoBehaviour
{
    GameObject[] emailOverlays;

    private void Start()
    {
        emailOverlays = GameObject.FindGameObjectsWithTag("EmailOverlay");

    }
    public void pressButton()
    {
        foreach (GameObject emailOverlay in emailOverlays)
        {
            emailOverlay.SetActive(false);
        }
    }
}
