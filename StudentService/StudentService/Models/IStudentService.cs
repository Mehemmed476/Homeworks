namespace StudentService.Models;

public interface IStudentService
{
    Student GetStudentById(int id);
    
    Student[] GetAllStudents();
    
    Student[] GetStudentsByName(string name);

    public void AddStudent(Student student);
    
    public void UpdateStudent(int id);
    
    public void RemoveStudent(int id, bool isSoftDelete);
}