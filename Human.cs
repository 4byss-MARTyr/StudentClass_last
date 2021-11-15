using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public enum Sex
    {
        Male,
        Female
    }
    public class Human
    {

        private Address address;
        private string _name;
        private string _surname;
        private int _age;
        private Sex Sex;

        public Human(string name, string surname, int age, Sex sex)
        {
            _name = name;
            _surname = surname;
            _age = age;
            Sex = sex;
        }

        private Address Address { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public Sex sex { get; set; }


        public Human()
        {
            Console.WriteLine("Input name: ");
            _name = Console.ReadLine();
            Console.WriteLine("Input surname: ");
            _surname = Console.ReadLine();
            Console.WriteLine("Input age: ");
            string ageStr = Console.ReadLine();
            int.TryParse(ageStr, out _age);
            Console.WriteLine("Input gender:(male or female) ");
            string InputGender = Console.ReadLine();

            if (InputGender == "male")
            {
                Sex = Sex.Male;
            }
            else if(InputGender == "female")
            {
                Sex = Sex.Female;
            }
            else
            
            { 
                Console.WriteLine("Error..."); 
            }
            Address = new Address();

        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name}, Surname: {_surname}, Age: {_age}, Sex: {Sex}");
            Address.GetInfo();
        }

        public string GetInfoToString()
        {
            string str = $"Name: {_name}, Surname: {_surname}, Age: {_age}, Sex: {Sex}";
            return str;
        }

    }
}