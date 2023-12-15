using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
       
        List<Student> students = new List<Student>();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Write the details for Student {i}:");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string number = Console.ReadLine();
            string department = Console.ReadLine();
            Student studentInstance = new Student
            {
                Name = name,
                Surname = surname,
                Number = number,
                Department = department
            };
            students.Add(studentInstance);
        
        Console.WriteLine("\nDetails of all students:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Number: {student.Number}, Department: {student.Department}");
        }
    }
}
