//LANGUAGE INTEGRATED QUERY (LINQ)
//Can chain into query expression

// Specify the data source.
// int[] scores = [97, 92, 81, 60];
List<int> scores = [97, 3, 55, 110, 92, 81, 60]; //Same as above "Sytactic Sugar"

//Declaritive Programming
// Define the query expression. (QUESTION)
IEnumerable<int> scoreQuery = //query variable
    from score in scores //do a for loop (for each)  //REQUIRED
    where score > 80 //for every score that is greater than 80
    orderby score descending //order by decending
    select score; //Select and give me that score //MUST end with select or group

//Method Syntax
//Basically the same as above but different style
var scoreQueryMethod = scores.Where(s => s > 80).OrderByDescending(s => s);

// Execute the query. To produce the :  (ANSWER)
//we are for eaching over the expression and writing it to console
foreach (var i in scoreQuery)
{
  Console.Write(i + " ");
}

// Output: 97 92 81

IEnumerable<string> scoreString =
    from score in scores //do a for loop (for each)
    where score > 80 //for every score that is greater than 80
    orderby score descending //order by decending
    select $"The score is {score}";

foreach (var i in scoreString)
{
  Console.Write(i + " ");
}
/*
The score is 97
The score is 92
The score is 81
*/