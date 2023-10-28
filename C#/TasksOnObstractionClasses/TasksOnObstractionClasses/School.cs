using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOnObstractionClasses
{
    abstract class School
    {
        public string SchoolName { get; set; }
        public string SchoolDescription { get; set; }
        abstract public void PrintInfo();
        public School(string schoolName, string schoolDescription)
        {
            SchoolDescription = schoolDescription;
            SchoolName = schoolName;
        }
    }
    class Teacher : School
    {
        public string TeacherName { get; set; }
        public string TeacherSubject { get; set; }
        public string TeacherIncome {  get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine(TeacherName);
            Console.WriteLine(TeacherSubject);
            Console.WriteLine(TeacherIncome);
        }
        public Teacher(string schoolName, string schoolDescription, string teacherName, string teacherSubject, string teacherIncome) : base( schoolName,  schoolDescription)
        {
            TeacherName = teacherName;
            TeacherSubject = teacherSubject;
            TeacherIncome = teacherIncome;
        }
    }
    class Student : School
    {
        public string StudentName { get; set; }
        public double StudentGrade { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine(StudentName);
            Console.WriteLine(StudentGrade);
        }
        public Student(string schoolName, string schoolDescription, string studentName, double studentGrade) : base(schoolName, schoolDescription)
        {
            StudentName = studentName;
            StudentGrade = studentGrade;
        }
    }
}
