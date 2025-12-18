using ClassesDemo;

var csharp49 = new Classroom();

var aaron = new Person();// Person is now a type, like string, int, double... looks like a method and is a special method called a constructor. Uses the blueprint we made(class), and builds the Person

// Dot notation - uses dot notation to access Person
aaron.Name = "Aaron"; // Can assign this because of the set in the property of my class Person
aaron.Age = 40;
aaron.clothes = "t-shirt & shorts";
aaron.wallet = 5100;

csharp49.CodingClass.Add(aaron);



// Object Initializer Syntax
var clara = new Person() 
{
    Name = "Clara", 
    Age = 15, 
    clothes = "Dress",
    wallet = 500
};

csharp49.CodingClass.Add(clara);

// Using a custom constructor
var maddie = new Person("Maddie", 17);

csharp49.CodingClass.Add(maddie);

csharp49.GreetEveryone();