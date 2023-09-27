using System;
using System.Collections.Generic;

namespace Student.core
{
    public interface IStudentServices
    {
        List<StudentObj> GetStudents();
        StudentObj GetStudentById(int id);
        StudentObj AddStudent(StudentObj student);
        StudentObj UpdateStudent(int id, StudentObj student);
        StudentObj DeleteStudent(int id);
    }
}
