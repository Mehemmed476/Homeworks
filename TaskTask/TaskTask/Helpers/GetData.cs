namespace DirectoryTask.Helpers;

public class GetData
{
    public static async Task<string> RetrieveHTMLDataAsync(string url)
    {
        HttpClient client = new HttpClient();
        string JsonData = await client.GetStringAsync(url);
        return JsonData;
    }
}