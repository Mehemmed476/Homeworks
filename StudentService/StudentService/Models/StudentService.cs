namespace StudentService.Models;

public class StudentService : Student, IStudentService
{
    private Student[] students = new Student[0];

    public StudentService()
    {
        
    }
    public StudentService(string firstName, string lastName, string email, string phoneNumber, double gpa, string status, string major) : base(firstName, lastName, email, phoneNumber, gpa, status, major)
    {
        
    }
    
    public void AddStudent(Student student)
    {
        Array.Resize(ref students, students.Length + 1);
        Student newStudent = new Student(FirstName, LastName, Email, PhoneNumber, GPA, Status, Major);
        students[^1] = newStudent;
    }

    public void UpdateStudent(int id)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Id == id)
            {
                Console.WriteLine("""
                                  Select Update part: 
                                  1. First Name:
                                  2. Last Name:
                                  3. Email:
                                  4. PhoneNumber:
                                  5. GPA:
                                  6. Status:
                                  7. Major:
                                  """);
                string choice = Console.ReadLine();
                switch (choice) 
                {
                    case "1":
                        string newFirstName = Console.ReadLine();
                        students[i].FirstName = newFirstName;
                        break;
                    case "2":
                        string newLastName = Console.ReadLine();
                        students[i].LastName = newLastName;
                        break;
                    case "3":
                        string newEmail = Console.ReadLine();
                        students[i].Email = newEmail;
                        break;
                    case "4":
                        string newPhoneNumber = Console.ReadLine();
                        students[i].PhoneNumber = newPhoneNumber;
                        break;
                    case "5":
                        double newGPA = double.Parse(Console.ReadLine());
                        students[i].GPA = newGPA;
                        break;
                    case "6":
                        string newStatus = Console.ReadLine();
                        students[i].Status = newStatus;
                        break;
                    case "7":
                        string newMajor = Console.ReadLine();
                        students[i].Major = newMajor;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            }
        }
    }

    public void RemoveStudent(int id, bool isSoftDelete = false)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Id == id)
            {
                if (isSoftDelete)
                {
                    students[i].Status = "Removed";
                }
                else
                {
                    students[i] = null; 
                } 
            }
        }
    }

    public Student GetStudentById(int id)
    {
        foreach (var student in students)
        {
            if (student != null && student.Id == id)
            {
                return student;
            }
        }
        return null;
    }

    public Student[] GetAllStudents()
    {
        return students;
    }

    public Student[] GetStudentsByName(string name)
    {
        Student[] tempResult = new Student[students.Length];
        int index = 0;

        string lowerName = name.ToLower();

        foreach (var student in students)
        {
            if (student != null && (student.FirstName.ToLower() == lowerName || student.LastName.ToLower() == lowerName))
            {
                tempResult[index++] = student;
            }
        }

        if (index == 0)
        {
            return null;
        }

        Student[] result = new Student[index];
        for (int i = 0; i < index; i++)
        {
            result[i] = tempResult[i];
        }

        return result;
    } 
}