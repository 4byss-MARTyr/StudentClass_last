using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherList teacherList = new TeacherList();

            Teacher t1 = new Teacher(new Address("Ukraine", "Kyiv", "Lenina", 4), "Matvey", "Ihorievich", 39, Sex.Male, "Mathematics", 5);
            teacherList.AddTeacher(t1);
        }
    }
    
}
