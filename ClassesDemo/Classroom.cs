namespace ClassesDemo;

public class Classroom
{
    // Properties can be of type List or Array
    public List<Person> CodingClass { get; set; } = new List<Person>();
    
    // Method (non static method for now)
    public void GreetEveryone()
    {
        foreach (var student in CodingClass)
        {
            // call the method for each student of type Person
            student.Greet();
        }
    }
}