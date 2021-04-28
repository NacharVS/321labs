using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Reflection
{
    class Student : IDisposable
    {
        public delegate void AgeChangedDelegate();

        private string _name;
        private int _age;

        public string Group { get; set; }

        public Student(string name)
        {
            _name = name;
        }

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"{_name} {_age}");
        }

        public static int SetAge(int age)
        {
            return age;
        }

        public void ApplyAge(int age)
        {
            _age = SetAge(age);
            AgeChangedEvent?.Invoke();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public event AgeChangedDelegate AgeChangedEvent;

    }
}
