using System.Diagnostics;
using System.Security.Cryptography;
using StudentService.Models;

namespace StudentService;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        string userFirstName;
        string userLastName;
        string userEmail;
        string userPhoneNumber;
        double userGPA;
        string userStatus;
        string userMajor;
        
        Models.StudentService newStudent = new Models.StudentService();
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("""
                              Welcome to Student Service
                              1. Add Student
                              2. Update Student
                              3. Delete Student
                              4. Find All Students
                              5. Find Student By ID
                              6. Find Student By Name
                              7. Exit
                              """);
            Console.Write("Please select an option(1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("First Name: ");
                    userFirstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    userLastName = Console.ReadLine();
                    Console.Write("Email: ");
                    userEmail = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    userPhoneNumber = Console.ReadLine();
                    Console.Write("GPA: ");
                    userGPA = double.Parse(Console.ReadLine());
                    Console.Write("Status: ");
                    userStatus = Console.ReadLine();
                    Console.Write("Major: ");
                    userMajor = Console.ReadLine();
                    
                    newStudent = new Models.StudentService(userFirstName, userLastName, userEmail, userPhoneNumber, userGPA, userStatus, userMajor);
                    
                    newStudent.AddStudent(newStudent);
                    Console.WriteLine("New student added");
                    
                    Thread.Sleep(2000);
                    
                    break;
                
                case "2":
                    Console.Write("Id : ");
                    int UId = int.Parse(Console.ReadLine());
                    newStudent.UpdateStudent(UId);
                    Console.WriteLine("Student successfully updated");
                    
                    Thread.Sleep(2000);
                    
                    break;
                
                case "3":
                    Console.Write("Id : ");
                    int DId = int.Parse(Console.ReadLine());
                    newStudent.RemoveStudent(DId);
                    Console.WriteLine("Student successfully removed");
                    
                    Thread.Sleep(2000);
                    
                    break; 
                
                case "4":
                    Student[] students = newStudent.GetAllStudents();

                    foreach (Student student in students)
                    {
                        Console.WriteLine($"ID: {student.Id} \nName: {student.FirstName} \nSurname: {student.LastName} \nEmail: {student.Email} \nPhone Number: {student.PhoneNumber} \nGPA: {student.GPA} \nStatus: {student.Status} \nMajor: {student.Major}");
                    }
                    
                    Thread.Sleep(2000);
                    
                    break;
                
                case "5":
                    Console.Write("Id : ");
                    int SId = int.Parse(Console.ReadLine());
                    Student selectedStudent = newStudent.GetStudentById(SId);
                    Console.WriteLine($"ID: {selectedStudent.Id} \nName: {selectedStudent.FirstName} \nSurname: {selectedStudent.LastName} \nEmail: {selectedStudent.Email} \nPhone Number: {selectedStudent.PhoneNumber} \nGPA: {selectedStudent.GPA} \nStatus: {selectedStudent.Status} \nMajor: {selectedStudent.Major}");
                    
                    Thread.Sleep(2000);
                    
                    break;
                
                case "6":
                    Console.Write("Name : ");
                    string name = Console.ReadLine();
                    Student[] studentsWithName = newStudent.GetStudentsByName(name);
                    foreach (Student item in studentsWithName)
                    {
                        Console.WriteLine($"ID: {item.Id} \nName: {item.FirstName} \nSurname: {item.LastName} \nEmail: {item.Email} \nPhone Number: {item.PhoneNumber} \nGPA: {item.GPA} \nStatus: {item.Status} \nMajor: {item.Major}");
                    } 
                    
                    Thread.Sleep(2000);
                    
                    break;
                
                case "7":
                    running = false;
                    Console.WriteLine("Thank you for using Student Service");
                    
                    Thread.Sleep(2000);
                    
                    break;
            }
        }
    }
}