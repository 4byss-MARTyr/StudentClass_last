using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class TeacherList
    {
        private List<Teacher> _teachers;

        public TeacherList()
        {
            _teachers = new List<Teacher>();
        }
        
        public List<Teacher> Teachers 
        { 
            get 
            { 
                return _teachers; 
            } 
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (_teachers.Contains(teacher))
            {
                _teachers.Remove(teacher);
            }
        }

        public List<Teacher> Sort()
        {
            SortedDictionary<string, Teacher> teachersDict = new SortedDictionary<string, Teacher>();
            foreach (var teacher in Teachers)
            {
                teachersDict[teacher.name + " " + teacher.surname] = teacher;
            }

            List<Teacher> sortedTeachers = new List<Teacher>();
            foreach (var teacher in teachersDict)
            {
                sortedTeachers.Add(teacher.Value);
            }

            return sortedTeachers;
        }

        public Teacher Find(string name)
        {
            foreach (var teacher in Teachers)
            {
                if (teacher.name == name)
                {
                    return teacher;
                }
            }

            return null;
        }

    }
}
