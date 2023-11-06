using System.Collections.Generic;

[System.Serializable]
public class EmailData
{
    public string Sender;
    public string Subject;
    public string Body;
    public List<Attachment> Attachments;

    public EmailData(string sender, string subject, string body, List<Attachment> attachments)
    {
        Sender = sender;
        Subject = subject;
        Body = body;
        Attachments = attachments ?? new List<Attachment>();
    }
}

[System.Serializable]
public class Attachment
{
    public string FileName;
    public string FileURL; // URL to download the attachment if applicable

    public Attachment(string fileName, string fileURL)
    {
        FileName = fileName;
        FileURL = fileURL;
    }
}
