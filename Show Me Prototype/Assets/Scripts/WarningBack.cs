using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningBack : MonoBehaviour
{
    
    public void OnWarningButtonPressed()
    {
        //disable current object
        gameObject.SetActive(false);
    }
}
