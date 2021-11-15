using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Student : Human
    {
        public Mark Mark;
        public Random num = new Random();

       
        private Mark mark { get; set; }
        public Student(string name, string surname, int age, Sex sex, int group, char faculty, Address adr, Mark _mark)
           : base(name, surname, age, sex)
        {
            _mark = mark;
            Mark = (Mark)num.Next(1, 5);
        }



        public void GetInfo()
        {
            Console.WriteLine($"Student: Name { name}, Surname: { surname}, Mark: { Mark}");
        }

        public string GetInfoToString()
        {
            string str = $"Student: Name { name}, Surname: { surname}, Mark: { Mark}";
            return str;
        }
    }
}
