using LibaryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.BusinessObject
{
    public class StudentObject
    {
        private static StudentObject instance = null;
        private static readonly object instanceLock = new object();
        private StudentObject() { }
        public static StudentObject Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StudentObject();
                    }
                    return instance;
                }
            }
        }
        public Student GetStudentByID(string Id)
        {
            Student student = null;
            try
            {
                var myLibrary = new LibraryManagementContext();
                student = myLibrary.Students.SingleOrDefault(student => student.StudentId == Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }
        public IEnumerable<Student> GetStudentList()
        {
            List<Student> students;
            try
            {
                var myLibrary = new LibraryManagementContext();
                students = myLibrary.Students.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return students;
        }
        public void AddStudent(Student student)
        {
            try
            {
                Student s = GetStudentByID(student.StudentId);
                if (s == null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Students.Add(student);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The student is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateStudent(Student student)
        {
            try
            {
                using (var myLibrary = new LibraryManagementContext())
                {
                    var existingStudent = myLibrary.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
                    if (existingStudent != null)
                    {
                        existingStudent.StudentName = student.StudentName;
                        existingStudent.Phone = student.Phone;
                        existingStudent.Dob = student.Dob;
                        existingStudent.Address = student.Address;

                        myLibrary.Entry(existingStudent).State = EntityState.Modified;
                        myLibrary.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("The student does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating student: {ex.Message}");
            }
        }

        public void DeleteStudent(string studentId)
        {
            try
            {
                using (var myLibrary = new LibraryManagementContext())
                {
                    var student = myLibrary.Students.FirstOrDefault(s => s.StudentId == studentId);
                    if (student != null)
                    {
                        myLibrary.Students.Remove(student);
                        myLibrary.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("The student does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting student: {ex.Message}");
            }
        }
    }
}
