using UnityEngine;

[System.Serializable] // Ensure it shows up in the inspector if you need it to
public class Email
{
    public string sender;
    public string subject;
    public string timeReceived;
    public GameObject body;
    public bool isRead = false;

    public Email(string sender, string subject, string timeReceived, GameObject body, bool isRead)
    {
        this.sender = sender;
        this.subject = subject;
        this.timeReceived = timeReceived;
        this.body = body;
        this.isRead = isRead;
    }

    public void MarkAsRead()
    {
        isRead = true;
    }
}