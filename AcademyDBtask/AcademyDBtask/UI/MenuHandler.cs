using AcademyDBtask.Models;

namespace AcademyDBtask.UI;

using System;
using System.Collections.Generic;
using AcademyDBtask.Services.Concretes;

public class MenuHandler
{
    private readonly StudentService _studentService;

    public MenuHandler()
    {
        _studentService = new StudentService();
    }

    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Student Management System ===");
            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Update a Student");
            Console.WriteLine("4. Delete a Student");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ViewAllStudents();
                    break;
                case "3":
                    UpdateStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void AddStudent()
    {
        Console.Clear();
        Console.WriteLine("=== Add New Student ===");

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Date of Birth (yyyy-mm-dd): ");
        DateTime dateOfBirth;
        while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
        {
            Console.Write("Invalid date! Enter again (yyyy-mm-dd): ");
        }

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password (min 8 characters): ");
        string password = Console.ReadLine();

        Console.Write("Enrollment Date (yyyy-mm-dd): ");
        DateTime enrollmentDate;
        while (!DateTime.TryParse(Console.ReadLine(), out enrollmentDate))
        {
            Console.Write("Invalid date! Enter again (yyyy-mm-dd): ");
        }

        try
        {
            _studentService.Create(new Student
            {
                FirstName = firstName,
                LastName = lastName,
                DataOfBirth = dateOfBirth,
                Username = username,
                Password = password,
                EnrollmentDate = enrollmentDate
            });

            Console.WriteLine("Student added successfully! Press Enter to return to the menu...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.ReadLine();
    }

    private void ViewAllStudents()
    {
        Console.Clear();
        Console.WriteLine("=== View All Students ===");

        try
        {
            List<Student> students = _studentService.GetAll();

            if (students.Count == 0)
            {
                Console.WriteLine("No students found!");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Username: {student.Username}, Enrollment Date: {student.EnrollmentDate.ToShortDateString()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    private void UpdateStudent()
    {
        Console.Clear();
        Console.WriteLine("=== Update Student ===");

        Console.Write("Enter Student ID to Update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            try
            {
                var students = _studentService.GetAll();
                var student = students.Find(s => s.Id == id);

                if (student == null)
                {
                    Console.WriteLine("Student not found!");
                }
                else
                {
                    Console.Write($"First Name ({student.FirstName}): ");
                    string firstName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(firstName)) student.FirstName = firstName;

                    Console.Write($"Last Name ({student.LastName}): ");
                    string lastName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(lastName)) student.LastName = lastName;

                    Console.Write($"Date of Birth ({student.DataOfBirth:yyyy-MM-dd}): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth)) student.DataOfBirth = dateOfBirth;

                    Console.Write($"Username ({student.Username}): ");
                    string username = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(username)) student.Username = username;

                    Console.Write($"Password (min 8 characters): ");
                    string password = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(password)) student.Password = password;

                    Console.Write($"Enrollment Date ({student.EnrollmentDate:yyyy-MM-dd}): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime enrollmentDate)) student.EnrollmentDate = enrollmentDate;

                    _studentService.Update(student);
                    Console.WriteLine("Student updated successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID!");
        }
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    private void DeleteStudent()
    {
        Console.Clear();
        Console.WriteLine("=== Delete Student ===");

        Console.Write("Enter Student ID to Delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            try
            {
                _studentService.Delete(id);
                Console.WriteLine("Student deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID!");
        }
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }
}


