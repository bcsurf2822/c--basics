// See https://aka.ms/new-console-template for more information

// int counter = 0;
//WHILE
/*
while (counter < 10)
{
    Console.WriteLine($" The counter is {counter}");
    counter++;//
} //Writes line 10 times


//DO WHILE
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);  //Do this while the counter is less then 10


//FOR LOOP (do while is basically the same thing)
for (
  int i = 0; //initialize at 0
 i < length; //conditional  
  i++) //iteration (increment)

for (int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}"); //Runs This Code 10 times
}
*/

for (int row = 1; row < 11; row++)
{
  Console.WriteLine($"The row is {row}");
}

for (char column = 'a'; column < 'k'; column++)
{
  Console.WriteLine($"The column is {column}");
}

for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}