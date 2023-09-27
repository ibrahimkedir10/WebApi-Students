using Microsoft.AspNetCore.Mvc;
using Student.core;
using System.Collections.Generic;

namespace WebApiStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentServices _studentservices;

        public StudentsController(IStudentServices studentServices)
        {
            _studentservices = studentServices;
        }

        [HttpGet] // Read
        public IActionResult GetStudents()
        {
            var students = _studentservices.GetStudents();
            return Ok(students);
        }

        [HttpPost] // Create
        public IActionResult AddStudent(StudentObj student)
        {
            var addedStudent = _studentservices.AddStudent(student);
            return Ok(addedStudent);
        }

        [HttpPut("{id}")] // Update
        public IActionResult UpdateStudent(int id, StudentObj student)
        {
            // Assuming you have a method in IStudentServices to update a student by ID
            var updatedStudent = _studentservices.UpdateStudent(id, student);

            if (updatedStudent == null)
            {
                return NotFound(); // Student not found
            }

            return Ok(updatedStudent);
        }

        [HttpDelete("{id}")] // Delete
        public IActionResult DeleteStudent(int id)
        {
            // Assuming you have a method in IStudentServices to delete a student by ID
            var deletedStudent = _studentservices.DeleteStudent(id);

            if (deletedStudent == null)
            {
                return NotFound(); // Student not found
            }

            return Ok(deletedStudent);
        }
    }
}
