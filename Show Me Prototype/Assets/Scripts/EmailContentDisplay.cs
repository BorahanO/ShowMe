using System.Net.Mail;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EmailContentDisplay : MonoBehaviour
{
    public TextMeshProUGUI emailBodyText; // Reference to the text element for the email body
    public GameObject attachmentButtonPrefab; // Prefab for attachment buttons
    public Transform attachmentPanel; // Parent transform where attachment buttons will be instantiated

    // Call this method to populate the email content display
    public void ShowEmailContent(EmailData emailData)
    {
        emailBodyText.text = emailData.Body;

        // Clear previous attachment buttons
        foreach (Transform child in attachmentPanel)
        {
            Destroy(child.gameObject);
        }

        // Create new attachment buttons
        foreach (var attachment in emailData.Attachments)
        {
            GameObject buttonObj = Instantiate(attachmentButtonPrefab, attachmentPanel);
            // Set up the button however you need to, including click listeners
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = attachment.FileName;
            buttonObj.GetComponent<Button>().onClick.AddListener(() => DownloadAttachment(attachment));
        }
    }

    private void DownloadAttachment(Attachment attachment)
    {
        // Implement the logic to handle the downloading of the attachment
    }
}
