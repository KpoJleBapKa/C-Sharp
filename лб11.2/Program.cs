using System;
using System.Collections.Generic;

namespace лб11._2
{
    public static class Extension
    {
        public delegate bool StudentPredicateDelegate(Student student);

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        public static bool IsAge18OrAbove(Student student)
        {
            return student.Age >= 18;
        }

        public static bool FirstNameStartsWithA(Student student)
        {
            return student.FirstName.StartsWith("A");
        }

        public static bool LastNameLongerThan3Chars(Student student)
        {
            return student.LastName.Length > 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Extension.Student> students = new List<Extension.Student>()
            {
                new Extension.Student() { FirstName = "Alice", LastName = "Smith", Age = 20 },
                new Extension.Student() { FirstName = "Bob", LastName = "Johnson", Age = 17 },
                new Extension.Student() { FirstName = "Charlie", LastName = "Williams", Age = 21 },
                new Extension.Student() { FirstName = "Dave", LastName = "Brown", Age = 16 },
                new Extension.Student() { FirstName = "Eve", LastName = "Jones", Age = 18 },
                new Extension.Student() { FirstName = "Frank", LastName = "Miller", Age = 22 },
                new Extension.Student() { FirstName = "Grace", LastName = "Taylor", Age = 15 },
                new Extension.Student() { FirstName = "Henry", LastName = "Moore", Age = 19 },
                new Extension.Student() { FirstName = "Ivy", LastName = "Anderson", Age = 14 },
                new Extension.Student() { FirstName = "Jack", LastName = "Thomas", Age = 20 }
            };
        }
    }
}
