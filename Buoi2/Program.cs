using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(001, "Nguyen Van A", 18),
            new Student(002, "Tran Van B", 14),
            new Student(003, "Anh Van C", 16),
            new Student(004, "Ngo Van D", 19),
            new Student(005, "Luong Van T", 17)
        };

        Console.WriteLine("Danh sach toan bo hoc sinh:");
        students.ForEach(student => Console.WriteLine($"Id: {student.Id}| Name: {student.FullName}      | Age: {student.Age}"));
        Console.WriteLine();


        var ageRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18:");
        foreach (var student in ageRange)
        {
            Console.WriteLine($"Id: {student.Id} | Name: {student.FullName}     | Age: {student.Age}");
        }
        Console.WriteLine();


        var nameA = students.Where(s => s.FullName.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Danh sach hoc sinh co ten bat dau bang chu 'A':");
        foreach (var student in nameA)
        {
            Console.WriteLine($"Id: {student.Id} | Name: {student.FullName}      | Age: {student.Age}");
        }
        Console.WriteLine();


        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"Tong tuoi cua tat ca hoc sinh sinh: {totalAge}");
        Console.WriteLine();


        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        if (oldestStudent != null)
        {
            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            Console.WriteLine($"Id: {oldestStudent.Id} | Name: {oldestStudent.FullName}      | Age: {oldestStudent.Age}");
        }
        Console.WriteLine();


        var sortedStudents = students.OrderBy(s => s.Age);
        Console.WriteLine("Danh sach hoc sinh sau khi sap xep tuoi tang dan:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id} | Name: {student.FullName}      | Age: {student.Age}");
        }
    }
}
