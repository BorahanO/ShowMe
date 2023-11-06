using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmailSetRead : MonoBehaviour
{

    public Email email;

    void Start()
    {
        email = GetComponent<Email>();
    }

    public void SetRead()
    {
        email.isRead = true;
    }
}
