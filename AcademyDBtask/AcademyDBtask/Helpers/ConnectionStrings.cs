namespace AcademyDBtask.Helpers;

public static class ConnectionStrings
{
    private static string _connectionString = @"Server=localhost;Database=AcademyDB;User ID=SA; Password=reallyStrongPwd123;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True";

    public static string ConnectionString
    {
        get => _connectionString;
        set => _connectionString = value;
    }
}