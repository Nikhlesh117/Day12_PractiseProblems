using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Expression
    {
        List<Student> list = new List<Student>();

        public void Display_Record()
        {
            foreach (var item in list)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Phone Number: " + item.PhoneNumber);
                Console.WriteLine("Address: " + item.Address);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine();
            }
        }
        public void Retrieve_Records_Using_Linq()
        {
            var records = from student in list
                          where student.Age >= 12 && student.Age <= 18
                          select student;

            foreach (var item in records)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Phone Number: " + item.PhoneNumber);
                Console.WriteLine("Address: " + item.Address);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine();
            }
        }
        public void Sort_Records()
        {
            var records = list.OrderByDescending(student => student.TotalMarks);

            foreach (var item in records)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Phone Number: " + item.PhoneNumber);
                Console.WriteLine("Address: " + item.Address);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Total Marks: " + item.TotalMarks);
                Console.WriteLine();
            }
        }

        public void Display_Address()
        {
            var address = list.Select(student => student.Address);
            
            foreach (var item in address)
            {
                Console.WriteLine(item);
            }
        }


        public void AddStudent(Student student)
        {
            list.Add(student);
        }



    }
}
