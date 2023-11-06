using UnityEngine;
using UnityEngine.UI;
using TMPro; // Ensure you have the TextMeshPro namespace if using TMP

public class EmailUI : MonoBehaviour
{
    public TextMeshProUGUI senderText;
    public TextMeshProUGUI subjectText;
    public TextMeshProUGUI timeReceivedText;
    public Image unreadIndicator; // Reference to the unread indicator image

    private Email emailData;
    private GameObject bodyPanel; // This will hold the email body panel to show/hide

    private void Start()
    {
        UpdateUnreadIndicator();
    }
    

    public void Setup(Email email)
    {
        emailData = email;

        // Assuming you have set these up in the editor
        senderText.text = email.sender;
        subjectText.text = email.subject;
        timeReceivedText.text = email.timeReceived;
        bodyPanel = email.body;
        bodyPanel.SetActive(false); // Initially the body is hidden
    }

    public void OnEmailSelected()
    {
        // Toggle visibility of the associated email body
        bool isActive = bodyPanel.activeSelf;
        bodyPanel.SetActive(!isActive);
        SetRead();

        // If you want to ensure only one email body is open at a time,
        // you could loop through all EmailUI instances and deactivate their bodies.
        if (!isActive)
        {
            EmailUI[] allEmailUIs = FindObjectsOfType<EmailUI>();
            foreach (EmailUI ui in allEmailUIs)
            {
                if (ui != this && ui.bodyPanel != null)
                {
                    ui.bodyPanel.SetActive(false);
                }
            }
        }
    }
    public void SetRead()
    {
        emailData.MarkAsRead();
        UpdateUnreadIndicator();
    }

    private void UpdateUnreadIndicator()
    {
        if (emailData.isRead)
        {
            // If the email is read, hide the unread indicator
            unreadIndicator.enabled = false;
        }
        else
        {
            // If the email is unread, show the unread indicator
            unreadIndicator.enabled = true;
        }
    }
}
