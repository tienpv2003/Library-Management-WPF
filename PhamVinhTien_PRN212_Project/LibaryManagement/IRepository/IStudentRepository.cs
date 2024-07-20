using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetStudents();
        public Student GetStudenByID(string studentId);
        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        public void DeleteStudent(string studentId);
    }
}
