using System;
using System.Linq;
using ConsoleApp11.Contextes;
using ConsoleApp11.Entities;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ITIdBContext())
            {
                var student = new Student
                {
                    FName = "Ahmed",
                    LName = "Ali",
                    Address = "Cairo",
                    Age = 22,
                    Dep_Id = 1
                };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student Added Successfully.");

                var students = context.Students.ToList();
                foreach (var student1 in students) 
                {
                    Console.WriteLine($"{student1.ID}: {student1.FName} {student1.LName}");
                }

                var existingStudent = context.Students.FirstOrDefault(s => s.ID == 1);
                if (existingStudent != null)
                {
                    existingStudent.Address = "Giza";
                    context.SaveChanges();
                    Console.WriteLine("Student Updated Successfully.");
                }

                var studentToDelete = context.Students.FirstOrDefault(s => s.ID == 1);
                if (studentToDelete != null)
                {
                    context.Students.Remove(studentToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Student Deleted Successfully.");
                }
            }
        }
    }
}
