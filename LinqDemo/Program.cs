using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudents();


            // var result = from s in students
            //     where s.Age >= 18
            //         select s;

            var result =
                students
                    .Where(x => x.Age >= 18)
                    .Where(x => x.StudentID > 1)
                    ;

            foreach (var student in result)
            {
                Console.Out.WriteLine(student);
            }

            students.Add(new Student()
            {
                StudentID = 15, StudentName = "aaa", Age = 20
            });

            foreach (var student in result)
            {
                Console.Out.WriteLine(student);
            }

            var s = students
                .Where(x => x.Age >= 18)
                .Select(x => new Employee() { Name = x.StudentName})
                .ToList();

            int x = 10;
            x.IsGreaterThan(15);

        }
    }
}
