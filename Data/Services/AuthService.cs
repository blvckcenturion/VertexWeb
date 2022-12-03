using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using VertexWeb.Data.Models;

namespace VertexWeb.Data.Services;

public class AuthService
{
    private ProtectedLocalStorage _protectedLocalStorage;

    public AuthService(ProtectedLocalStorage protectedLocalStorage)
    {
        _protectedLocalStorage = protectedLocalStorage;
    }

    public async Task StoreCredentials(string id, int userType, string institutionId)
    {
        await _protectedLocalStorage.SetAsync("id", id);
        await _protectedLocalStorage.SetAsync("userType", userType);
        await _protectedLocalStorage.SetAsync("institutionId", institutionId);
    }

    public async Task ClearCredentials()
    {
        await _protectedLocalStorage.DeleteAsync("id");
        await _protectedLocalStorage.DeleteAsync("userType");
        await _protectedLocalStorage.DeleteAsync("institutionId");
    }

    public async Task<Credentials> GetCredentials()
    {
        var id = await _protectedLocalStorage.GetAsync<string>("id");
        var userType = await _protectedLocalStorage.GetAsync<int>("userType");
        var institutionId = await _protectedLocalStorage.GetAsync<string>("institutionId");
        if (id.Success && userType.Success && institutionId.Success)
        {
            return new Credentials
            {
                Id = id.Value,
                UserType = userType.Value,
                InstitutionId = institutionId.Value
            };
        }
        return null;
    }

    public async Task<User> GetUser()
    {
        var credentials = await GetCredentials();
        Console.WriteLine("YES");
        if (credentials != null)
        {
            var firestoreDb = new FirestoreService().firestoreDb;
            var collection = firestoreDb.Collection("User");
            Console.WriteLine(credentials.Id);
            var snapshot = collection.Document(credentials.Id).GetSnapshotAsync();

            if (snapshot != null)
            {
                var user = snapshot.Result.ConvertTo<User>();
                if (user.Status != 0)
                {
                    return user;
                }
            }

            // var snapshot = await query.GetSnapshotAsync();
            // Console.WriteLine(snapshot.Count);

            // if (snapshot.Count > 0)
            // {
            //     var user = snapshot.Documents[0].ConvertTo<User>();
            //     Console.WriteLine("YES");
            //     return user;
            // }
        }
        return null;
    }

}

public class Credentials
{
    public int? UserType { get; set; }
    public string? Id { get; set; }
    public string? InstitutionId { get; set; }

    public Credentials(string id, int userType, string institutionId)
    {
        UserType = userType;
        Id = id;
        InstitutionId = institutionId;
    }

    public Credentials()
    {
        Id = null;
        UserType = null;
        InstitutionId = null;
    }
}