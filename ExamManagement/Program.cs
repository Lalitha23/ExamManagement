using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student
            {
                LastName = "John",
                FirstName = "George",
                StudentLevel = Level.Level1
            };

            Console.WriteLine($"student1: {student1.FirstName} {student1.LastName} Level: {student1.StudentLevel} Age:{student1.MinimumAge}");
        }
    }
}
