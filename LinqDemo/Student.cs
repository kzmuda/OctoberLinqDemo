using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{StudentID} {StudentName} {Age}";
        }

        public static List<Student> GetStudents()
        {
            return new List<Student> {
                new Student { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
        }
    }
}
