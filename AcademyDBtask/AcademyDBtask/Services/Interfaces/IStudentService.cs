using AcademyDBtask.Models;

namespace AcademyDBtask.Services.Interfaces;

public interface IStudentService
{
    public void Create(Student student);
    public List<Student> GetAll();
    public void Update(Student student);
    public void Delete(int id);
}