using UnityEngine;

public class EmailBody : MonoBehaviour
{
    // This method will be called when the back button is clicked
    public void OnBackButtonPressed()
    {
        // Deactivate this email body panel
        this.gameObject.SetActive(false);
    }
}
