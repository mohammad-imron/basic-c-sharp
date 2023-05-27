// See https://aka.ms/new-console-template for more information
int firstnumber;
int secondnumber;
Console.Write("Please put first number : ");
firstnumber = int.Parse(Console.ReadLine());
Console.Write("Please put Second number : ");
secondnumber = int.Parse(Console.ReadLine());
var ResultAdding = firstnumber + secondnumber;
var ResultSubstract = firstnumber - secondnumber;
var ResultMultiply = firstnumber * secondnumber;
var ResultDivide = firstnumber / secondnumber;
Console.WriteLine($"Result of {firstnumber} + {secondnumber} = {ResultAdding}");
Console.WriteLine($"Result of {firstnumber} - {secondnumber} = {ResultSubstract}");
Console.WriteLine($"Result of {firstnumber} * {secondnumber} = {ResultMultiply}");
Console.WriteLine($"Result of {firstnumber} / {secondnumber} = {ResultDivide}");
