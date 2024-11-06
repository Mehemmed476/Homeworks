using System.Diagnostics;
using DirectoryTask.Helpers;
using DirectoryTask.Models;
using Newtonsoft.Json;

namespace TaskTask;

class Program
{
    static void Main(string[] args)
    {
        /*#region Task 1 main

        Stopwatch sw = Stopwatch.StartNew();
                
                List<string> urls = new List<string>()
                {
                    "https://www.microsoft.com/en-us/",
                    "https://www.meta.com",
                    "https://www.freelancer.com"
                };
                
                RetrieveHTMLData(urls);
                Console.WriteLine($"Completed in {sw.ElapsedMilliseconds} ms.");
                
                Console.WriteLine("------------------------------------------------------------------");
                
                sw.Restart();
                
                RetrieveHTMLDataAsync(urls).Wait();
                Console.WriteLine($"Completed in {sw.ElapsedMilliseconds} ms.");

        #endregion*/

        #region Task 2
        
            string path = @"/Users/mehemmedxelilzade/RiderProjects/TaskTask/TaskTask";
            string modelsDirPath = path + @"/Models";
            string dataDirPath = path + @"/Data";
        
            Directory.CreateDirectory(modelsDirPath);
            Directory.CreateDirectory(dataDirPath);
        
            string userFilePath = modelsDirPath + @"/User.cs";
            string jsonDataFilePath = dataDirPath + @"/jsonData.json";
        
            if (!File.Exists(userFilePath))
            {
                File.Create(userFilePath).Close();
            }

            if (!File.Exists(jsonDataFilePath))
            {
                File.Create(jsonDataFilePath).Close();
            }
        
            string link = @"https://jsonplaceholder.typicode.com/posts";

            string jsonData = GetData.RetrieveHTMLDataAsync(link).Result;
        
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
        
            string jsonUsers = JsonConvert.SerializeObject(users, Formatting.Indented);
        
            File.WriteAllText(jsonDataFilePath, jsonUsers);

        #endregion
    }

    #region Task 1 Methods
    public static void RetrieveHTMLData(List<string> urls)
    {
        HttpClient client = new HttpClient();

        foreach (var item in urls)
        {
            client.GetStringAsync(item).Result.ToString();
        }
    }

    public static async Task RetrieveHTMLDataAsync(List<string> urls)
    {
        HttpClient client = new HttpClient();

        List<Task<string>> tasks = new List<Task<string>>();
        
        foreach (var item in urls)
        {
            tasks.Add(client.GetStringAsync(item));
        }
        
        await Task.WhenAll(tasks);
    }
    
    #endregion
}