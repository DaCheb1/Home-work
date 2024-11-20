using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public List<int> Marks { get; set; }

    public Person(string name, List<int> marks)
    {
        Name = name;
        Marks = marks;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Создаем список из 5 объектов Person
        List<Person> people = new List<Person>()
        {
            new Person("Иван", new List<int> { 4, 5, 3, 4, 5 }),
            new Person("Петр", new List<int> { 3, 2, 4, 3, 5 }),
            new Person("Сидор", new List<int> { 5, 5, 5, 4, 5 }),
            new Person("Андрей", new List<int> { 2, 3, 4, 2, 3 }),
            new Person("Федор", new List<int> { 4, 4, 3, 5, 4 })
        };

        // Используем LINQ для создания нового списка с именем и средней оценкой
        var studentAverages = people.Select(p => new
        {
            Name = p.Name,
            AverageMark = p.Marks.Average()
        }).ToList();

        // Выводим результаты
        Console.WriteLine("Имя студента\tСредняя оценка");
        foreach (var student in studentAverages)
        {
            Console.WriteLine($"{student.Name}\t\t{student.AverageMark:F2}");
        }
    }
}