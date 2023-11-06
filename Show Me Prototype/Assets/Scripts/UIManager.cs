using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    public GameObject emailPrefab;
    public Transform emailListParent;

    [SerializeField] private List<Email> emails = new List<Email>(); // Make this serializable and initialize

    void Start()
    {
        PopulateEmails();
    }

    void Update()
    {
        // Update the timer text here if needed
    }

    public void RefreshEmailLayout()
    {
        // This forces the vertical layout group to re-arrange its children immediately
        LayoutRebuilder.ForceRebuildLayoutImmediate(emailListParent.GetComponent<RectTransform>());
    }

    void PopulateEmails()
    {
        // Clear previous entries to avoid duplication
        foreach (Transform child in emailListParent)
        {
            Destroy(child.gameObject);
        }

        // Instantiate new email UI objects for each email data
        foreach (var email in emails)
        {
            GameObject emailObj = Instantiate(emailPrefab, emailListParent);
            emailObj.GetComponent<EmailUI>().Setup(email);
        }

        // Refresh the layout to account for the new objects
        RefreshEmailLayout();
    }
}
