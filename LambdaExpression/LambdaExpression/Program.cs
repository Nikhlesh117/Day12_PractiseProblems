using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Expression expression = new Expression();

            // Create students
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Bruce Wayne", PhoneNumber = "1234567890", Address = "1007 Mountain Drive", Age = 20 ,TotalMarks=88},
                new Student { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210", Address = "456 Avenue", Age = 15,TotalMarks=90 },
                new Student { Id = 3, Name = "Clark Kent", PhoneNumber = "5551234567", Address = "344 Clinton Street", Age = 18,TotalMarks = 65 },
                new Student { Id = 4, Name = "Emily Brown", PhoneNumber = "4567890123", Address = "567 Lane", Age = 10,TotalMarks=56 }
            };

            foreach (var student in students)
            {
                expression.AddStudent(student);
            }

            // Display all student records
            //Console.WriteLine("All Student Records:");
            //expression.Display_Record();

            // Retrieve student records using LINQ for ages between 12 and 18
            //Console.WriteLine("Student Records with Ages between 12 and 18:");
            //expression.Retrieve_Records_Using_Linq();

            Console.WriteLine("Students with Total Marks in Descending Order:");
            expression.Sort_Records();

            Console.ReadLine();
        }
    }
}
