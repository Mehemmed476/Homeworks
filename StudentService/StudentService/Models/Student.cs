using System.Runtime;

namespace StudentService.Models;

public class Student
{
    private static int _id;

    public int Id => _id;
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
     
    public string Email { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public double GPA { get; set; }
    
    public string Status { get; set; }
    
    public string Major { get; set; }

    public Student()
    {
        
    }
    public Student(string firstName, string lastName, string email, string phoneNumber, double gpa, string status, string major)
    {
        _id++;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        GPA = gpa;
        Status = status;
        Major = major;
    }
    
}