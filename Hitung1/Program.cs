// See https://aka.ms/new-console-template for more information
int firstnumber;
int secondnumber;

Console.WriteLine("Hello, World!");
Console.Write("input first number : ");
firstnumber  = int.Parse(Console.ReadLine());
Console.Write("input second number : ");
secondnumber  = int.Parse(Console.ReadLine());
var result = firstnumber * secondnumber;
Console.WriteLine($"Result is  {result}");
