// //OOP C# at its core

// using System;
// // {} are all scoping //Older C# code might look like this
// namespace MyNamespace
// {
//   public class MyApp
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Hello John");
//     }
//   }
// }


//Class Constructors

var p = new Person("Ben", "Corbett", new DateOnly(1990, 2, 8));
var e = new Person("Laura", "Corbett", new DateOnly(1993, 3, 8));
p.Pets.Add(new Dog("Buck"));
e.Pets.Add(new Cat("Boots"));

List<Person> people = [p, e];

foreach (var person in people)
{
  Console.WriteLine($"{person}'s pet is");
  foreach (var pet in person.Pets)
  {
    Console.WriteLine($"{pet}");
  }
}



public class Person(string firstname, string lastname, DateOnly birthday)
{
  public string First { get; set; } = firstname;
  public string Last { get; } = lastname;

  public DateOnly Birthday { get; } = birthday;

  public List<Pet> Pets { get; } = new();

  public override string ToString()
  {
    return $"{First} {Last}";
  }
}



public abstract class Pet(string firstname)
{
  public string First { get; } = firstname;
  public abstract string MakeNoise(); //blueprint

  public override string ToString()
  {
    return $"{First}, a {GetType().Name} and I {MakeNoise()}";
  }
}


public class Cat(string firstname) : Pet(firstname)
{

  public override string MakeNoise() => "meow";
}

public class Dog(string firstname) : Pet(firstname)
{

  public override string MakeNoise() => "BARK";
}