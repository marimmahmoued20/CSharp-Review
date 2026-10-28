using System;

// 1. Create a Person class
class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Constructor: initializes the person's information
    public Person(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    // Displays the person's information
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Email: {Email}";
    }
}

class Program
{
    static void Main()
    {
        // 2. Value Type Practice
        Console.WriteLine("===== Value Type Practice =====");

        int x = 10;
        int y = 5;

        y = x;
        x = 20;

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        // y remains 10 because it received a copy of x's value.

        // 3. Reference Type Practice
        Console.WriteLine("\n===== Reference Type Practice =====");

        Person p1 = new Person(1, "Ahmed", "ahmed@gmail.com");
        Person p2 = new Person(2, "Sara", "sara@gmail.com");

        Console.WriteLine("Before p1 = p2:");
        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");

        p1 = p2;
        p1.Name = "Mariam";

        Console.WriteLine("\nAfter p1 = p2 and changing p1.Name:");
        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");

        // Both variables refer to the same object, so the name changes for both.

        // 4. Object Reassignment
        Console.WriteLine("\n===== Object Reassignment =====");

        p1 = new Person(3, "Omar", "omar@gmail.com");

        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");

        // p1 now refers to a new object.
        // p2 still refers to the previous object.

        // 5. Challenge
        Console.WriteLine("\n===== Challenge =====");

        Person p3 = p2;

        p3.Email = "newemail@gmail.com";

        Console.WriteLine("After changing p3.Email:");
        Console.WriteLine($"p2: {p2}");
        Console.WriteLine($"p3: {p3}");

        p3 = new Person(4, "Ali", "ali@gmail.com");

        Console.WriteLine("\nAfter assigning a new object to p3:");
        Console.WriteLine($"p2: {p2}");
        Console.WriteLine($"p3: {p3}");

        // Changing p3.Email affects p2 because both refer to the same object.
        // Assigning a new object to p3 does not change p2.
    }
}