
using ping;
using Lists;
using Arraysss;
using GenericClasses;

Arrayss arrays = new Arrayss();
arrays.Arr();
Pinger pinger =  new Pinger();
pinger.PerformPing();


Listss myPartsList = new Listss(); // Instantiate the Lists class from the Lists namespace

// Adding parts
myPartsList.AddPart("Engine", 1);
myPartsList.AddPart("Wheel", 2);
myPartsList.AddPart("Brake", 3);

// Displaying parts
myPartsList.DisplayParts();

var intBox = new Box<int>(123);
intBox.DisplayInfo(); // Output: Type: System.Int32, Value: 123

// Create an instance of Box with string
var stringBox = new Box<string>("Hello Generics");
stringBox.DisplayInfo(); // Output: Type: System.String, Value: Hello Generics

// Create an instance of Box with a custom class
var personBox = new Box<Person>(new Person("John", "Doe"));
personBox.DisplayInfo(); // Output: Type: Namespace.Person, Value: Person { FirstName = John, LastName = Doe }

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"Person {{ FirstName = {FirstName}, LastName = {LastName} }}";
    }
}