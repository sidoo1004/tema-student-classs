using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentExceptions;


namespace tema_student_classs
{
    class Student
    {
        private int age;
        private string name;
        private const int min_Age = 18;
        private const int max_Age = 99;
        private int mark;
        public Student()
        {

        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= min_Age && value <= max_Age)
                    age = value;
                else Console.WriteLine("varsta nu e buna");

            }
        }
            public int Mark { get; set; }
        public string Info
        {
            get { return name + " " + age; }
        }
        

    }
}
