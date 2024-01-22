using Platform.Implementations;
using Platform.Interfaces;
using Platform.Models;

IStudentService studentService = new StudentService();

// Create some students
Student student1 = new Student { StudentId = 1, FirstName = "John", LastName = "Doe", Grade = 80 };
Student student2 = new Student { StudentId = 2, FirstName = "Jane", LastName = "Smith", Grade = 90 };

// Add students
studentService.Create(student1);
studentService.Create(student2);

// Get all students
List<Student> allStudents = studentService.GetAll();

// Print all students
foreach (var student in allStudents)
{
    Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
}