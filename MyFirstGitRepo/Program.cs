// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello Git");

// Adding a new feature
Console.WriteLine("This is a new feature added to the code.");

foreach (var arg in args)
{
    Console.WriteLine($"Argument: {arg}");
}

var numbers = new List<int> { 1, 2, 3, 4, 5 };
foreach (var number in numbers)
{
    Console.WriteLine($"Number: {number}");
}

// Adding a new feature to print the sum of numbers
int sum = numbers.Sum();
Console.WriteLine($"Sum of numbers: {sum}");
// Adding a new feature to print the average of numbers
double average = numbers.Average();
Console.WriteLine(average > 3 ? "Average is greater than 3" : "Average is less than or equal to 3");