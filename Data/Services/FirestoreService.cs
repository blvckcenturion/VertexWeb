using Google.Cloud.Firestore;

namespace VertexWeb.Data.Services;

public class FirestoreService
{
    public FirestoreDb firestoreDb;

    public FirestoreService()
    {
        var projectName = "pos1-bef91";
        var authFilePath = "POS.json";
        // environment variable could be configured differently, but for the sample simply hardcode it
        // the Firestore library expects this environment variable to be set
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", authFilePath);
        firestoreDb = FirestoreDb.Create(projectName);
    }

}