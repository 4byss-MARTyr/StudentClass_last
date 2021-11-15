using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    enum Mark
    {
        F = 1,
        D = 2,
        C = 3, 
        B = 4, 
        A = 5, 
    }

    class Teacher : Human
    {
        private string _discipline;
        private int _cоurse_number;

        private List<Student> _students;

        public Teacher(Address address, string name, string surname, int age, Sex sex, string discipline, int course_number)
            :base(name,surname,age, sex)
        {
            _discipline = discipline;
            _cоurse_number = course_number;

            _students = new List<Student>();
        }
        private string discipline { get; }
        private int course_number { get; set; }
        
        public void RegisterStudent(Student student)
        {
            _students.Add(student);
        }

        public void UnregisterStudent(Student student)
        {
            if (_students.Contains(student))
            {
                _students.Remove(student);
            }
        }
        
        public List<Student> SortStudentsByMarks()
        {
            SortedDictionary<int, Student> studentDict = new SortedDictionary<int, Student>();
            foreach (Student student in _students)
            {
                studentDict[(int)student.Mark] = student;
            }

            List<Student> sortedStudents = new List<Student>();
            foreach (var student in studentDict)
            {
                sortedStudents.Add(student.Value);
            }

            sortedStudents.Reverse();
            return sortedStudents;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Teacher - Discipline: {discipline}, Course Number: {course_number}. Human: {base.ToString()}");
        }

        public string GetInfoToString()
        {
            string str = $"Teacher - Discipline: {discipline}, Course Number: {course_number}. Human: {base.ToString()}";
            return str;
        }
    }
}
