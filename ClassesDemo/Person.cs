namespace ClassesDemo;

public class Person
{
    // Fields (a member of a class) - a variable inside a class (camel case)
    public int wallet;
    public string clothes;
    
    // Properties (another member of a class) - things that define the class (Pascal Case)
    public string Name { get; set; } // get allows us to read what the property is, set allows me to change what it is
    public int Age { get; set; } 
    
    // Methods (non-static examples to follow)
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
    
    // Constructor
    
    // Default Constructor - a special method that builds using the blueprint, our object
    public Person()
    {
        
    }
    
    // Custom Constructor (can have as many custom constructors as you want
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    // Having both methods is an example of method overloading
}