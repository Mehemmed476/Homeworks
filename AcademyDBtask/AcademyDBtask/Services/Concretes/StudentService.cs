using AcademyDBtask.Helpers;
using AcademyDBtask.Models;
using AcademyDBtask.Services.Interfaces;

namespace AcademyDBtask.Services.Concretes;

public class StudentService : IStudentService
{
    public void Create(Student student)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.ConnectionString))
            {
                string query = @"INSERT INTO Students (FirstName, LastName, DataOfBirth, Username, Password, EnrollmentDate)
                                 VALUES (@FirstName, @LastName, @DataOfBirth, @Username, @Password, @EnrollmentDate)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@DataOfBirth", student.DataOfBirth);
                command.Parameters.AddWithValue("@Username", student.Username);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"SQL Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    
    public List<Student> GetAll()
    {
        List<Student> students = new List<Student>();
        try
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.ConnectionString))
            {
                string query = "SELECT * FROM Students";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        DataOfBirth = (DateTime)reader["DataOfBirth"],
                        Username = (string)reader["Username"],
                        Password = (string)reader["Password"],
                        EnrollmentDate = (DateTime)reader["EnrollmentDate"]
                    });
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"SQL Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return students;
    }
    
    public void Update(Student student)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.ConnectionString))
            {
                string query = @"UPDATE Students
                                 SET FirstName = @FirstName, LastName = @LastName, DataOfBirth = @DataOfBirth, 
                                     Username = @Username, Password = @Password, EnrollmentDate = @EnrollmentDate
                                 WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@DataOfBirth", student.DataOfBirth);
                command.Parameters.AddWithValue("@Username", student.Username);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"SQL Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    
    public void Delete(int id)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.ConnectionString))
            {
                string query = "DELETE FROM Students WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"SQL Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

