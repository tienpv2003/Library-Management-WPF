using LibaryManagement.BusinessObject;
using LibaryManagement.Models;
using LibaryManagement.IRepository;
using System.Collections.Generic;

namespace LibaryManagement.Repository
{
    public class StudentRepository : IStudentRepository
    {

        public Student GetStudenByID(string studentId) => StudentObject.Instance.GetStudentByID(studentId);

        public IEnumerable<Student> GetStudents() => StudentObject.Instance.GetStudentList();
        public void AddStudent(Student student) => StudentObject.Instance.AddStudent(student);

        public void DeleteStudent(string studentId) => StudentObject.Instance.DeleteStudent(studentId);

        public void UpdateStudent(Student student) => StudentObject.Instance.UpdateStudent(student);
    }
}
