//List Collections
using System.Globalization;

var names = new List<string> { "John", "Ana", "Felipe" };

foreach (var name in names) //foreach is special saying it will loop over every name in this list knows how to iterate over any strings array 
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
/*
Hello John
Hello ANA!
Hello FELIPE!

*/

//INDEXING

Console.WriteLine(names[0]); //<name>
Console.WriteLine(names[^1]);//Marielle ^(count from back of arr)

var namesArray = new string[] { "Jason", "Tomas", "Brian" };//we are creating an array of strings
namesArray = [.. namesArray, "William"];//Copy prev entries and add WIlliam
foreach (var name in namesArray)
{
  Console.WriteLine(name);
}

//SORTING AND SEARCH

var sortedNames = new List<string> { "John", "Ana", "Felipe" };
sortedNames.Sort(); //sorts alpha
foreach (var name in sortedNames)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

var sortedNumbers = new List<int> { 22, 33, 5, 65, 75, 353 };
sortedNumbers.Sort(); //sorts numerically
Console.WriteLine($"I found 22 at index {sortedNumbers.IndexOf(22)}"); //22 is at index of 1
foreach (var num in sortedNumbers)
{
  Console.WriteLine($"{num}");
}