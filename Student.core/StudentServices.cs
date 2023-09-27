using System;
using System.Collections.Generic;
using System.Linq;

namespace Student.core
{
    public class StudentServices : IStudentServices
    {
        private readonly List<StudentObj> _students;
        private int _nextId = 1;

        public StudentServices()
        {
            // Initialize with a sample student
            _students = new List<StudentObj>
            {
                new StudentObj
                {
                    Id = _nextId++,
                    FirstName = "Ibrahim",
                    LastName = "Kedir"
                }
            };
        }

        public List<StudentObj> GetStudents()
        {
            return _students;
        }

        public StudentObj GetStudentById(int id)
        {
            return _students.FirstOrDefault(student => student.Id == id);
        }

        public StudentObj AddStudent(StudentObj student)
        {
            student.Id = _nextId++;
            _students.Add(student);
            return student;
        }

        public StudentObj UpdateStudent(int id, StudentObj updatedStudent)
        {
            var existingStudent = _students.FirstOrDefault(student => student.Id == id);

            if (existingStudent != null)
            {
                existingStudent.FirstName = updatedStudent.FirstName;
                existingStudent.LastName = updatedStudent.LastName;
                return existingStudent;
            }

            return null; // Student not found
        }

        public StudentObj DeleteStudent(int id)
        {
            var studentToRemove = _students.FirstOrDefault(student => student.Id == id);

            if (studentToRemove != null)
            {
                _students.Remove(studentToRemove);
                return studentToRemove;
            }

            return null; // Student not found
        }
    }
}
