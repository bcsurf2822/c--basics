string firstFriend = "        Laura";
firstFriend = firstFriend.Trim();
string secondFriend = "Ben";

string friends = $"{secondFriend}'s wife is {firstFriend}";
Console.WriteLine(friends);
//Replace Old String name , New String Name
friends = friends.Replace("Ben", "Bill");

Console.WriteLine(friends.ToUpper().Length);
Console.WriteLine(friends.Contains("Ben")); //Boolean
Console.WriteLine(secondFriend.StartsWith("Be"));


//C# has different range for numbers it can handle (to Big To Store)
decimal e = 332.1M;
// number can overflow +/-
decimal a = 42.1M; // natural type
decimal c = a + e;
// Console.WriteLine(c);
Console.WriteLine($"The answer is {c}");


