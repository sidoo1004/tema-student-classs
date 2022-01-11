using System;
using StudentExceptions;

namespace tema_student_classs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti varsta:");
            int varsta = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti numele :");
            string numele = Console.ReadLine();
            Student FirstStudent = new Student(numele, varsta);
            
            
            Console.WriteLine(FirstStudent.Info);
            
        }
    }
}
