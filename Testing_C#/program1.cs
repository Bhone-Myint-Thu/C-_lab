using System;

public class Person
{
    // Fields
    public string Name;
    public int Age;

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of the Person class
        Person person1 = new Person("John", 30);
        
        // Call the Greet method
        person1.Greet();
    }
}
