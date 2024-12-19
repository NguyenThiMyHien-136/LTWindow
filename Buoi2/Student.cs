using System;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        FullName = name;
        Age = age;
    }
}
